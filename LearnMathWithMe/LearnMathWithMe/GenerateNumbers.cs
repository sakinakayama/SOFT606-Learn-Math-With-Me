using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearnMathWithMe
{
    class GenerateNumbers
    {
        public int firstNum;
        public int secondNum;
        public int result;
        public void GenerateRandomNo()  //Create the method of generating numbers
        {
            Random random = new Random();

            if (User.schoolYear == 1)
            {
                firstNum = random.Next(0, 9);
                secondNum = random.Next(1, 9);
            }

            else if (User.schoolYear == 2)
            {
                firstNum = random.Next(10, 99);
                secondNum = random.Next(10, 99);
            }

            else if (User.schoolYear == 3)
            {
                firstNum = random.Next(10, 200);
                secondNum = random.Next(10, 200);
            }

        }

        public void Addition()
        {
            result = firstNum + secondNum;
        }

        public void Subtraction()
        {
            result = firstNum - secondNum;
        }

        public void Multiplication()
        {
            result = firstNum * secondNum;
        }
        public void Division()
        {
            try
            {
                result = firstNum / secondNum;
            }
            catch(DivideByZeroException)
            {
               
            }
        }
    }
}
