using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3_HWS_BasicArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Qst 1

            //int[] myArr = new int[10];
            //int counter = 0;
            //myArr[counter++] = int.Parse(Console.ReadLine());
            //myArr[counter++] = int.Parse(Console.ReadLine());
            //myArr[counter++] = int.Parse(Console.ReadLine());
            //myArr[counter++] = int.Parse(Console.ReadLine());
            //myArr[counter++] = int.Parse(Console.ReadLine());
            //myArr[counter++] = int.Parse(Console.ReadLine());
            //myArr[counter++] = int.Parse(Console.ReadLine());
            //myArr[counter++] = int.Parse(Console.ReadLine());
            //myArr[counter++] = int.Parse(Console.ReadLine());
            //myArr[counter] = int.Parse(Console.ReadLine());

            //Console.WriteLine(myArr[counter--]);
            //Console.WriteLine(myArr[counter--]);
            //Console.WriteLine(myArr[counter--]);
            //Console.WriteLine(myArr[counter--]);
            //Console.WriteLine(myArr[counter--]);
            //Console.WriteLine(myArr[counter--]);
            //Console.WriteLine(myArr[counter--]);
            //Console.WriteLine(myArr[counter--]);
            //Console.WriteLine(myArr[counter--]);
            //Console.WriteLine(myArr[counter--]);

            #endregion

            #region Qst 2

            char[] myStrArr = new char[7] { 'H', 'A', 'C', 'K', 'E', 'R', 'U' };
            Console.WriteLine(myStrArr[0] + myStrArr[1]);
            //......

            //Advance:
            string allChars = String.Join("", myStrArr);
            Console.WriteLine(allChars);

            #endregion

            #region Qst 3

            int[] myIntArr1 = new int[10];
            int[] myIntArr2 = new int[10];

            for (int i = 0; i < myIntArr1.Length; i++)
            {
                myIntArr1[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < myIntArr1.Length; i++)
            {
                myIntArr2[i] = myIntArr1[i];
            }

            myIntArr1[5] = -1;
            myIntArr1[9] = -1;

            for (int i = 0; i < myIntArr2.Length; i++)
            {
                Console.WriteLine(myIntArr2[i]);
            }

            #endregion

            #region Qst 4

            int[] myIntArr3 = new int[10];
            int[] myIntArr4 = new int[10];

            for (int i = 0; i < myIntArr3.Length; i++)
            {
                myIntArr3[i] = int.Parse(Console.ReadLine());
            }

            myIntArr4 = myIntArr3;

            myIntArr3[5] = -1;
            myIntArr3[9] = -1;

            for (int i = 0; i < myIntArr4.Length; i++)
            {
                Console.WriteLine(myIntArr4[i]);
            }

            #endregion

            #region Qst 5

            int numOfStudents = int.Parse(Console.ReadLine());
            float[] grades = new float[numOfStudents];
            float grade, sum = 0;
            for (int i = 0; i < grades.Length; i++)
            {
                grade = float.Parse(Console.ReadLine());
                grades[i] = grade;
            }
            for (int i = 0; i < grades.Length; i++)
            {
                sum += grades[i];
            }
            Console.WriteLine(sum);
            Console.WriteLine(sum / grades.Length);

            #endregion
        }
    }
}
