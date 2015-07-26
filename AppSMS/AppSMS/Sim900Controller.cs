using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace AppSMS
{
    class Sim900Controller
    {
        public List<Message> msg;

        public String sim900ReadSMSCmd = "at+cmgl=\"ALL\"\r\n";

        public String sim900DelSMSCmd = "at+cmgda=\"DEL ALL\"\r\n";

        public String sim900HangUpSMSCmd = "ath\r\n";

        public Sim900Controller()
        {
            msg = new List<Message>();
        }

        public Boolean IsSimModuleAlive()
        {
            return false;
        }

        public Boolean DeleteSMS(int position)
        {

            return false;
        }

        public Boolean ReadSMS(String rBuff)
        {
            int pLast;
            String str;
            List<String> msgBuff = new List<string>();
            int i = 0;

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
            return true;
        }

        public Boolean IsNewMessage(String buff)
        {
            if (buff.IndexOf("+CMTI") >= 0)
            {
                return true;
            }
            return false;
        }

        public Boolean IsIncomingCall(String buff)
        {
            if (buff.IndexOf("RING") >= 0)
            {
                return true;
            }
            return false;
        }

        public void WriteCommand(String cmd)
        {
             
        }

        private Boolean IsStringReceived(String str)
        {

            return false;
        }
        
    }
}
