using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSMS
{
    class Sim900Controller
    {
        public Sim900Controller()
        {
        }

        public Boolean IsSimModuleAlive()
        {

            return false;
        }

        public Boolean DeleteSMS(int position)
        {

            return false;
        }

        public Boolean ReadSMS(String message, int mLength, String phoneNumber, int nLength)
        {

            return false;
        }
        
        private void WriteCommand(String cmd)
        {

        }

        private Boolean IsStringReceived(String str)
        {

            return false;
        }
        
    }
}
