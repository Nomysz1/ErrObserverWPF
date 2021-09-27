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
                MailAddress mailAddress = new MailAddress(email);
            }
            catch (FormatException err)
            {
                result = false;
            }
            return result;
        }
    }
}
