using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Threading;

namespace AppSMS
{
    class Sim900Controller
    {
        private String recvBuff;

        private String sim900ReadSMSCmd = "at+cmgl=\"ALL\"\r\n";

        private String sim900DelSMSCmd = "at+cmgda=\"DEL ALL\"\r\n";

        private String sim900HangUpSMSCmd = "ath\r\n";

        public List<Message> msg;

        private void WriteCommand(SerialPort _sp, String cmd)
        {
            _sp.WriteLine(cmd);
        }

        public Sim900Controller()
        {
            msg = new List<Message>();
            recvBuff = "";
        }

        public Boolean InitSIM900(SerialPort _sp)
        {
            _sp.WriteLine("at+cnmi=2,3,0,0,0\r\n"); //configure sms delivery rule
            Thread.Sleep(500);
            recvBuff = _sp.ReadExisting();
            if (recvBuff.IndexOf("OK") < 0)
            {
                return false;
            }
            _sp.WriteLine("at+cmgf=1\r\n"); //enable text mode
            Thread.Sleep(500);
            _sp.ReadExisting();
            if (recvBuff.IndexOf("OK") < 0)
            {
                return false;
            }
            return true;
        }

        public void GetResponse(SerialPort _sp)
        {
            recvBuff = _sp.ReadExisting();
        }

        public Boolean IsSimModuleAlive(SerialPort _sp)
        {
            WriteCommand(_sp, "at\r\n");
            Thread.Sleep(500);
            recvBuff = _sp.ReadExisting();
            if (recvBuff.IndexOf("OK") < 0)
            {
                return false;
            }
            return true;
        }

        public void HangUpCall(SerialPort _sp)
        {
            WriteCommand(_sp, sim900HangUpSMSCmd);
        }

        public void DeleteSMS(SerialPort _sp)
        {
            WriteCommand(_sp, sim900DelSMSCmd);
        }

        public void ReadSMS(SerialPort _sp)
        {
            WriteCommand(_sp, sim900ReadSMSCmd);
        }

        public void HandleSMS(SerialPort _sp)
        {
            int pLast;
            String str, rBuff;
            List<String> msgBuff = new List<string>();
            int i = 0;
            
            rBuff = _sp.ReadExisting();

            //clear data from msg list first
            msg.RemoveRange(0, msg.Count);
            //divide rBuff into many msgBuff
            str = rBuff;
            while (str.IndexOf("+CMGL") != -1)
            {
                str = str.Substring(str.IndexOf("+CMGL") + 7);
                pLast = str.IndexOf("+CMGL");
                if (pLast == -1)
                {
                    Console.WriteLine(str.Substring(0));
                    pLast = str.IndexOf("\nOK");
                }
                Console.WriteLine(pLast);
                Console.WriteLine(str.Substring(0, pLast));
                msgBuff.Add(str.Substring(0,pLast));
            }

            for (i = 0; i < msgBuff.Count; i++)
            {
                Console.WriteLine(msgBuff[i]);

            }

            //handle parts of msgBuff
            for (i = 0; i < msgBuff.Count; i++)
            {
                Message tempMsg = new Message();

                //ID Message
                pLast = msgBuff[i].IndexOf(",");
                str = msgBuff[i].Substring(0, pLast);
                tempMsg.id = str;
                msgBuff[i] = msgBuff[i].Substring(pLast + 1);

                //State Message
                pLast = msgBuff[i].IndexOf(",");
                str = msgBuff[i].Substring(4, pLast - 5);
                tempMsg.state = str;
                msgBuff[i] = msgBuff[i].Substring(pLast + 1);

                //Phone number of Message
                pLast = msgBuff[i].IndexOf(",");
                str = msgBuff[i].Substring(1, pLast-2);
                tempMsg.phoneNumber = str;
                msgBuff[i] = msgBuff[i].Substring(pLast + 1);

                //NULL
                pLast = msgBuff[i].IndexOf(",");
                msgBuff[i] = msgBuff[i].Substring(pLast + 2);

                //Date of Message
                pLast = msgBuff[i].IndexOf("\"");
                str = msgBuff[i].Substring(0, pLast);
                tempMsg.date = str;
                msgBuff[i] = msgBuff[i].Substring(pLast + 3);

                //Content of Message
                str = msgBuff[i].Substring(0);
                tempMsg.content = str;

                msg.Add(tempMsg);
            }
        }

        public Boolean IsNewMessage()
        {
            if (recvBuff.IndexOf("+CMTI") < 0)
            {
                return false;
            }
            return true;
        }

        public Boolean IsIncomingCall()
        {
            if (recvBuff.IndexOf("RING") < 0)
            {
                return false;
            }
            return true;
        }
    }
}
