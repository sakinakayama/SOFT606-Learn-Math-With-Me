using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnMathWithMe
{
    class InvalidNumberException : Exception
    {
        public InvalidNumberException(String msg)
            :base(msg)
        {

        }
    }
}
