using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.exam.Exceptions
{
    public class CustomExeption:Exception
    {
        public CustomExeption()
        {
        }

        public CustomExeption(string message)
        : base(message)
         {
        }
    }
}
