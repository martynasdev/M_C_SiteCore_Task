using System;

namespace SiteCore_task_Martynas_Cizas
{
    class CountLettersInSentence
    {
        static void Main(string[] args)
        {
            string str;
            int i, cnt;
            Console.WriteLine("write some text...");
            str = Console.ReadLine();
            char ch;
            for (ch = (char)65; ch <= 90; ch++)
            {
                cnt = 0;
                for (i = 0; i < str.Length; i++)
                {

                    if (ch == str[i] || (ch + 32) == str[i])
                    {
                        cnt++;
                    }
                }
                if (cnt > 0)
                {
                    Console.WriteLine(ch + "=" + cnt);
                }
            }
            Console.ReadLine();
        }
    }
}
