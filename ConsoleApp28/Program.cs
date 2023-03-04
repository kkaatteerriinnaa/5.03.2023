using System;
using System.IO;
using System.Text;
using System.Threading;

namespace ConsoleApp28
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[] arr = new int[100];
            int count = 0;
            int fcount = 0;
            try
            { 
                StreamWriter sw = new StreamWriter("Count", true);

                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = r.Next(1, 100);
                    sw.WriteLine(arr[i]);
                    int k = 1;
                    for (int l = 1; l <= arr.Length; l += k)
                    {
                        fcount++;
                        k = l - k;
                    }
                }
                sw.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            count = arr.Length-fcount;
            Console.WriteLine("Простых чисел: "+count);
            Console.WriteLine("Чисел Фибоначчи: " + fcount);

            
            try
            {
                FileStream file = new FileStream("Test.txt", FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter("Test.txt", true);
                string line;
                Console.WriteLine("Введите искомое слово: ");
                string word1 = Console.ReadLine();
                Console.WriteLine("Введите слово на замену: ");
                string word2 = Console.ReadLine();
                Console.WriteLine("Введите любой текст: ");
                do
                {
                    line = Console.ReadLine();
                    sw.WriteLine(line);

                } while (line != "");
                sw.Close();
                line = line.Replace(word1, word2);
                file.Close();

                Console.WriteLine("Слово: " + word1 + " заменино на : " + word2);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                Console.WriteLine("Введите путь к файлу с тектом: ");
                Console.WriteLine("Введите путь к файлу со словами: ");
                string filetext = Console.ReadLine();
                StreamReader srt = new StreamReader(filetext, Encoding.UTF8);
                string fileword = Console.ReadLine();
                StreamReader srw = new StreamReader(fileword, Encoding.UTF8);


                Console.WriteLine(srt.ReadToEnd());
                srt.Close();
                srw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
