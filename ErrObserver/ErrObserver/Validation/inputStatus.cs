using System;
using System.Collections.Generic;
using System.Text;

namespace ErrObserver.Validation
{
    class inputStatus
    {
        private bool emailAddr;
        private bool to;
        private bool smtpNumber;
        private bool smtpHost;
        private bool extension;

        public inputStatus()
        {
            emailAddr = to = smtpNumber = smtpHost = extension = false;
        }

        public bool isAllValuesinitialised()
        {
            bool result = emailAddr == true && To == true && smtpNumber == true && smtpHost == true && extension == true ? true : false;
            return result;
        }

        public bool EmailAddr
        {
            get
            {
                return emailAddr;
            }
            set
            {
                emailAddr = value;
            }
        }
        public bool To
        {
            get
            {
                return to;
            }
            set
            {
                to = value;
            }
        }
        public bool SmtpNumber
        {
            get
            {
                return smtpNumber;
            }
            set
            {
                smtpNumber = value;
            }
        }
        public bool SmtpHost
        {
            get 
            {
                return smtpHost;
            }
            set
            {
                smtpHost = value;
            }
        }
        public bool Extension
        {
            get
            {
                return extension;
            }
            set
            {
                extension = value;
            }
        }
    }
}
