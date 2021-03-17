using System;
using System.Collections.Generic;
using System.Text;

namespace Exception
{
    public class RecordNotFoundException : System.Exception
    {
        public RecordNotFoundException(string message):base(message)
        {
            
        }
    }
}
