using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace prackt16
{
    public class PredmetYkazat
    {

        public string CountPaper(string word)
        {
            StreamReader book1 = File.OpenText("book1.txt");
            StreamReader book2 = File.OpenText("book2.txt");
            StreamReader book3 = File.OpenText("book3.txt");
            string rl = "";

            int countPaper = 0;
            string infaBook1 = "";
            string infaBook2 = "";
            string infaBook3 = "";

            while ((rl = book1.ReadLine()) != null)
            {
                int countBook1 = 0;
                string[] words = rl.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < words.Length; i ++)
                {
                    if (word == words[i])
                    {
                        countBook1++;
                        countPaper++;
                    }
                }
                infaBook1 = "Кол-во строк с нужным словом в первой книге = " + countBook1.ToString() + " ";
            }
            while ((rl = book2.ReadLine()) != null)
            {
                int countBook2 = 0;
                string[] words = rl.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < words.Length; i++)
                {
                    if (word == words[i])
                    {
                        countPaper++;
                        countBook2++;
                    }
                }
                infaBook2 = "Кол-во строк с нужным словом во второй книге = " + countBook2.ToString() + " ";
            }
            while ((rl = book3.ReadLine()) != null)
            {
                int countBook3 = 0;
                string[] words = rl.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < words.Length; i++)
                {
                    if (word == words[i])
                    {
                        countPaper++;
                        countBook3++;
                    }
                }
                infaBook3 = "Кол-во строк с нужным словом в третьей книге = " + countBook3.ToString() + " ";
            }
            book1.Close();
            book2.Close();
            book3.Close();
            return infaBook1 + infaBook2 + infaBook3 + "\nОбщее кол-во страниц = " + countPaper.ToString();        
        }

    }
}
