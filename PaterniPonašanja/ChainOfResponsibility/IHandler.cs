using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    public interface IHandler
    {
        public void proslijediDalje();
    }
}
