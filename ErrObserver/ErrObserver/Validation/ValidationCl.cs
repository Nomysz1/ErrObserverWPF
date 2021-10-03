using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Net.Mail;

namespace ErrObserver.Rgx
{
    class ValidationCl
    {
        static public bool checkEmailAddr(ref string email)
        {
            var result = true;
            try
            {
                MailAddress mailAddress;
                var length = email.Length;
                if (length > 0)
                    mailAddress = new MailAddress(email);
                else
                    result = false;
            }
            catch (FormatException)
            {
                result = false;
            }
            return result;
        }

        static public bool checkSMTPPort(ref string port)
        {
            var result = true;
            foreach(var element in port)
            {
                if (char.IsDigit(element) == false)
                    result = false;
            }
            return result;
        }

        static public bool checkExtension(ref string extension)
        {
            var result = true;
            foreach(var element in extension)
            {
                if (char.IsLetter(element) == false && element != '*')
                    result = false;
            }
            return result;
        }

        static public bool checkSMTPHost(ref string smtpHost)
        {
            var result = true;
            foreach(var element in smtpHost)
            {
                if (char.IsLetterOrDigit(element) == false && element != '.')
                    result = false;
            }   
            return result;
        }
    }
}
