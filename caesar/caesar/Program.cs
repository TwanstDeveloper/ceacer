using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        string Encrypt(string txt, int key)
        {
            string result = "";
            for (int i = 0; i < txt.Length; i++)
            {
                if (char.IsUpper(txt[i]))
                {

                    result = result + (char)((int)(txt[i] + key - 65) % 26 + 65);
                }

                else
                {

                    result = result + (char)((int)(txt[i] + key - 97) % 26 + 97);
                }
            }

            return result;


        }

        string Dencrypt(string txt, int key)
        {
            string result = "";
            for (int i = 0; i < txt.Length; i++)
            {
                if (char.IsUpper(txt[i]))
                {

                    result = result + (char)((int)(txt[i] - key - 65) % 26 + 65);
                }
                else
                {

                    result = result + (char)((int)(txt[i] - key - 97) % 26 + 97);
                }
            }

            return result;


        }
        static void Main(string[] args)
        {
            string txt = "ATTACKonTITAN";
            int key = 3;
            
            Program ob = new Program();
            string cipher = ob.Encrypt(txt, key);
            string plain = ob.Dencrypt(cipher, key);
            Console.WriteLine(cipher); 
            Console.WriteLine(plain);
            Console.ReadKey();
        }
    }
}
