using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace FileReader
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("../../../songs.txt");

            string data = sr.ReadLine();

            while(data != null)
            {
                Console.WriteLine(data);
                data = sr.ReadLine();

                string[] values = data.Split(',');
                int frequency = Int32.Parse(values[0]);
                int duration = Int32.Parse(values[1]); 
                Console.Beep(frequency, duration);
            }  
            //Console.WriteLine("This is just a test"); 

        }
    }
}
