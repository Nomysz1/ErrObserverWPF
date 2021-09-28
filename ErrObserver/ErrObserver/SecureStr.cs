using System;
using System.Collections.Generic;
using System.Text;
using System.Security;

namespace ErrObserver
{
    class SecureStr
    {
        public static SecureString encrypt(ref string str)
        {
            var secureString = new SecureString();
            foreach (var element in str)
                secureString.AppendChar(element);
            return secureString;
        }
    }
}
