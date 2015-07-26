using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSMS
{
    class Message
    {
        public Message()
        {
            _id = _phoneNumber = _content = _date = "";
        }

        private String _id;
        public String id
        {
            set { _id = value; }
            get { return _id; }
        }

        private String _state;
        public String state
        {
            set { _state = value; }
            get { return _state; }
        }

        private String _phoneNumber;
        public String phoneNumber
        {
            set { _phoneNumber = value; }
            get { return _phoneNumber; }
        }

        private String _date;
        public String date
        {
            set { _date = value; }
            get { return _date; }
        }

        private String _content;
        public String content
        {
            set { _content = value; }
            get { return _content; }
        }
    }
}
