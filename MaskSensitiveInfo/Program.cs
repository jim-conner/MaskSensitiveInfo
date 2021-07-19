using System;

namespace MaskSensitiveInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type in a secret...");
            string secret = Console.ReadLine();
            


            if (secret.Length > 4)
            {
                string result = secret.Substring(secret.Length - 4)
                .PadLeft(secret.Length, '*');
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Try a longer word next time.");
            }
        }
        //this helped me
        //https://stackoverflow.com/questions/9035192/mask-out-part-first-12-characters-of-string-with/9037991
    }
}
