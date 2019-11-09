using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power_Manager
{
    class DialogCancelResultException : ApplicationException
    {        
        public DialogCancelResultException(string message) : base(message)
        {
        }
    }
}
