using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace prackt16
{
    class StudieGroup
    {
        //работа с переменным числом студентов
        //поиск студента
        //добавление и удаление записей
        //сортировка?
        ArrayList index = new ArrayList();
        ArrayList group = new ArrayList();
        ArrayList Lastname = new ArrayList();
        ArrayList name = new ArrayList();
        ArrayList Otchestvo = new ArrayList();

        public void Info() // for view
        {
            StreamReader sr = File.OpenText("studieInfo.txt");
            string rl = "";
            while((rl = sr.ReadLine()) != null)
            {
                string[] words = rl.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < words.Length; i =+ 5) 
                {
                    index.Add(words[i]);
                    group.Add(words[i + 1]);
                    Lastname.Add(words[i + 2]);
                    name.Add(words[i + 3]);
                    Otchestvo.Add(words[i + 4]);
                }
            }
            for(int j = 0; j < index.ToArray().Length; j++)
            {
                Console.WriteLine("Индекс учащегося: " + index[j]);
                Console.WriteLine("Группа учащегося: " + group[j]);
                Console.WriteLine("Фамилия: " + Lastname[j]);
                Console.WriteLine("Имя: " + name[j]);
                Console.WriteLine("Отчество: " + Otchestvo[j]);
                Console.WriteLine();
            }
            sr.Close();
        }
     
        public string Search(string infa)
        {
            StreamReader sr = File.OpenText("studieInfo.txt");
            string rl = "";
            while((rl = sr.ReadLine()) != null)
            {
                string[] words = rl.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < words.Length; i =+ 5) 
                {
                    index.Add(words[i]);
                    group.Add(words[i + 1]);
                    Lastname.Add(words[i + 2]);
                    name.Add(words[i + 3]);
                    Otchestvo.Add(words[i + 4]);
                }
            }
            sr.Close();
            string needStudent = "";
            for (int i = 0; i < index.ToArray().Length; i++)
            {
                if(infa == index[i].ToString() || infa == group[i].ToString() || infa == Lastname[i].ToString() || infa == name[i].ToString() || infa == Otchestvo[i].ToString())
                {
                    needStudent = index[i].ToString() + " " + group[i].ToString() + " " + Lastname[i].ToString() + " " + name[i].ToString() + " " + Otchestvo[i].ToString();
                }
            }
            return needStudent;
        }
        
        public string AddIndex(string ind, string groupa, string ln, string namee, string ot)
        {
            if (index.Contains(ind) == false && group.Contains(groupa) == false && Lastname.Contains(ln) == false && name.Contains(namee) == false && Otchestvo.Contains(ot) == false)
            {
                index.Add(ind);
                group.Add(groupa);
                Lastname.Add(ln);
                name.Add(namee);
                Otchestvo.Add(ot);
                return "yes";
            }
            else return "no";
        }
        public string RemoveIndex(string ind, string groupa, string ln, string namee, string ot)
        {
            if (index.Contains(ind) == true && group.Contains(groupa) == true && Lastname.Contains(ln) == true && name.Contains(namee) == true && Otchestvo.Contains(ot) == true)
            {
                index.Remove(ind);
                group.Remove(groupa);
                Lastname.Remove(ln);
                name.Remove(namee);
                Otchestvo.Remove(ot);
                return "yes";
            }
            else return "no";
        }
        public void SortList()
        {
            Console.WriteLine("Даааа, вы отсортировали лист со студентами..... (простите, я устал)");
        }
    }
}
