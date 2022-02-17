using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnMathWithMe
{
    class InvalidCharactorException : Exception
    {
        public InvalidCharactorException(String msg)
            : base(msg)
        {

        }
    }
}
