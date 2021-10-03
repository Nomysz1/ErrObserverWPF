using System;
using System.Collections.Generic;
using System.Text;

namespace ErrObserver.Interfaces
{
    interface IEmail
    {
        void send(string dirPath, string filePath, string body);
        void sendTest();
    }
}
