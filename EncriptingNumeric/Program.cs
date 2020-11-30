using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncriptingNumeric
{
    class Program
    {
        static void Main(string[] args)
        {
            int password;

            do
            {
                Console.Write("Please, insert your 4 digits password in order to encrypt it: \n");

                if (int.TryParse(Console.ReadLine(), out password))
                {

                }

                else
                {
                    Console.Write("Password must be 4 digits long\n");
                }
            } while (Convert.ToString(password).Length != 4);


            Console.WriteLine(password);

            int[] passwordArray = password.ToString().Select(x => Convert.ToInt32(x) - 48 + 7).ToArray() ;

            int[] passwordIntArray = new int[4];
            for (int i = 0; i < 4; i++)
            {
                passwordIntArray[i] = passwordArray[i] % 10;
            }

            for (int i = 0; i < 2; i++)
            {
                var tempPass = passwordIntArray[i];
                passwordIntArray[i] = passwordIntArray[i + 2];
                passwordIntArray[i + 2] = tempPass;
            }

            var stringAppend = new StringBuilder();
            var finalstring = "";
            
            for (int i = 0; i < 4; i++)
            {
                stringAppend.Insert(i, Convert.ToString(passwordIntArray[i]));
            }

            finalstring = Convert.ToString(stringAppend);
            Console.WriteLine(stringAppend);

            Console.ReadLine();

            Console.Write("Now, let's do it the other way\nPlease, enter a password to decrypt it: ");
            var passToDecrypt = Console.ReadLine();

            do
            {
                Console.Write("Please, insert your 4 digits password in order to encrypt it: \n");

                if (int.TryParse(Console.ReadLine(), out password))
                {

                }

                else
                {
                    Console.Write("Password must be 4 digits long\n");
                }
            } while (Convert.ToString(password).Length != 4);


            Console.WriteLine(password);

            int[] passwordArray2 = password.ToString().Select(x => Convert.ToInt32(x) - 48 + 7).ToArray();

            int[] passwordIntArray2 = new int[4];
            for (int i = 0; i < 4; i++)
            {
                passwordIntArray[i] = passwordArray[i] % 10;
            }

            for (int i = 0; i < 2; i++)
            {
                var tempPass = passwordIntArray[i];
                passwordIntArray[i] = passwordIntArray[i + 2];
                passwordIntArray[i + 2] = tempPass;
            }

            var stringAppend2 = new StringBuilder();

            for (int i = 0; i < 4; i++)
            {
                int temp = 0;
                temp = ((passwordIntArray[i] - 7 + 10) % 10);
                stringAppend2.Insert(i, Convert.ToString(temp));
            }

            Console.WriteLine(stringAppend2);

            Console.ReadLine();
        }
    }
}
