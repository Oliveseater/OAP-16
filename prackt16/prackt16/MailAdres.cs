using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prackt16
{
    public class MailAdres
    {
        public ArrayList list = new ArrayList();

        public string CreateMail(string mail)
        {
            if (mail != "")
            {
                if (mail.IndexOf('@') > 1 && (mail.IndexOf('.') > 1))
                {
                    list.Add(mail);
                    return mail;
                }
                else return "Адрес написан не верно";
            }
            else return "Адрес написан не верно";
        }
        public string DeleteMail(string mail)
        {
            if (list.Contains(mail) == true)
            {
                list.Remove(mail);
                return "Successfully deleted";
            }
            else
            return "Mail not found";
        }
        public string ChangeMail(string mail)
        {
            if (list.Contains(mail) == true)
            {
                list.Remove(mail);
                mail = Console.ReadLine();
                mail = mail.Replace(mail, mail);
                list.Add(mail);
                return mail;
            }
            else return "Mail not found";
        }

    }
}
