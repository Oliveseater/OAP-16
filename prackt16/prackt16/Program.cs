using System;

namespace prackt16
{
    class Program
    {
        static void Main(string[] args)
        {
            MailAdres ma = new MailAdres();
            ComplexNumber cn = new ComplexNumber();
            Vector vector = new Vector();
            ArrayIntNumbers ain = new ArrayIntNumbers();
            StudieGroup sg = new StudieGroup();
            PredmetYkazat py = new PredmetYkazat();

            string mail = "";
            string stopWord = "GO";

            while (stopWord == "GO")
            {
                Console.WriteLine("Нажмите номер функции, которую вам необходимо выполнить:");
                Console.WriteLine("1. Создать почту\n2. Изменить существующую почту\n3. Удалить существующую почту\n4. Сумма комплексных чисел\n" +
                    "5. Вычитание комплексных чисел\n6. Умножение комплексных чисел\n7. Сумма и разность двух векторов в трехмерном пространстве\n" +
                    "8. Вычисление скалярного произведения двух векторов и длину получившегося вектора\n9. Oперация вычисления косинуса угла между векторами\n" +
                    "10. Вывести определённый элемент массива\n11. Создать массива в определённым размером\n12. Умножить каждый элемент массива на конкретное число\n" +
                    "13. Вывести определённый элемент массива и весь массив сразу же\n14. Вывод информации о студентах\n15. Поиск студента по его признаку\n" +
                    "16. Добавить или удалить в список студента\n17. Сортировка списка со студентами\n" +
                    "18. Поиск нужного слова в книгах\n");
                int value = Convert.ToInt32(Console.ReadLine());
                switch (value)
                {
                    case 1:
                        {
                            Console.WriteLine("Напишите почту");
                            mail = Console.ReadLine();
                            if (ma.CreateMail(mail) != "Адрес написан не верно") Console.WriteLine("Почта успешна создана!");
                            else Console.WriteLine("Вы совершили ошибку :(");
                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("Напишите почту");
                            mail = Console.ReadLine();
                            if (ma.ChangeMail(mail) != "Mail not found") Console.WriteLine("Вы успешно изменили почту!");
                            else Console.WriteLine("Такой почты не существует :(");

                        }
                        break;
                    case 3:
                        {
                            Console.WriteLine("Напишите почту");
                            mail = Console.ReadLine();
                            if (ma.DeleteMail(mail) != "Mail not found") Console.WriteLine("Вы успешно удалили почту!");
                            else Console.WriteLine("Такой почты не существует :(");
                        }
                        break;
                    case 4:
                        {
                            Console.WriteLine("Введите четыре комплексных числа по формуле (a+bi)+(c+di): ");
                            string a = Console.ReadLine();
                            string b = Console.ReadLine();
                            string c = Console.ReadLine();
                            string d = Console.ReadLine();
                            if (cn.SumComplex(a, b, c, d) == null) Console.WriteLine("Произошла какая-то ошибка :(");
                            else Console.WriteLine("Ваш ответ: " + cn.SumComplex(a, b, c, d));
                        }
                        break;
                    case 5:
                        {
                            Console.WriteLine("Введите четыре комплексных числа по формуле (a+bi)-(c+di): ");
                            string a = Console.ReadLine();
                            string b = Console.ReadLine();
                            string c = Console.ReadLine();
                            string d = Console.ReadLine();
                            if (cn.SubComplex(a, b, c, d) == null) Console.WriteLine("Произошла какая-то ошибка :(");
                            else Console.WriteLine("Ваш ответ: " + cn.SubComplex(a, b, c, d));
                        }
                        break;
                    case 6:
                        {
                            Console.WriteLine("Введите четыре комплексных числа по формуле (a+bi)(c+di): ");
                            string a = Console.ReadLine();
                            string b = Console.ReadLine();
                            string c = Console.ReadLine();
                            string d = Console.ReadLine();
                            if (cn.MulComplex(a, b, c, d) == null) Console.WriteLine("Произошла какая-то ошибка :(");
                            else Console.WriteLine("Ваш ответ: " + cn.MulComplex(a, b, c, d));
                        }
                        break;
                    case 7:
                        {
                            Console.WriteLine("Вам нужно написать в строку по 3 координаты (ijk) к каждому вектору:");
                            Console.WriteLine("Первый вектор а: ");
                            Console.Write("i: "); double x1 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("j: "); double y1 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("k: "); double z1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Второй вектор b: ");
                            Console.Write("i: "); double x2 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("k: "); double y2 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("j: "); double z2 = Convert.ToDouble(Console.ReadLine());            
                            Console.WriteLine("Cумма и разность двух векторов: " + vector.SumSub(x1, y1, z1, x2, y2, z2));
                        }
                        break;
                    case 8:
                        {
                            Console.WriteLine("Вам нужно написать в строку по 3 координаты (ijk) к каждому вектору:");
                            Console.WriteLine("Первый вектор а: ");
                            Console.Write("i: "); double x1 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("j: "); double y1 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("k: "); double z1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Второй вектор b: ");
                            Console.Write("i: "); double x2 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("k: "); double y2 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("j: "); double z2 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Скалярное произведение векторов и его длинна: " + vector.Scaliarnoe(x1, y1, z1, x2, y2, z2));
                        }
                        break;
                    case 9:
                        {
                            Console.WriteLine("Вам нужно написать в строку по 3 координаты (ijk) к каждому вектору:");
                            Console.WriteLine("Первый вектор а: ");
                            Console.Write("i: "); double x1 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("j: "); double y1 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("k: "); double z1 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Второй вектор b: ");
                            Console.Write("i: "); double x2 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("k: "); double y2 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("j: "); double z2 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Косинус угла между двумя векторами: " + vector.CosVector(x1, y1, z1, x2, y2, z2));
                        } 
                        break;
                    case 10:
                        {
                            Console.WriteLine("Введите индекс массива от 0 до 100, чтобы уведеть его элемент: ");
                            int index = Convert.ToInt32(Console.ReadLine());
                            if (ain.OneIndex(index) == 0) Console.WriteLine("Вы ввели индекс выходящий за рамки массива :(");
                            else Console.WriteLine("Ваш элемент: " + ain.OneIndex(index));                     
                        }
                        break;
                    case 11:
                        {
                            Console.WriteLine("Введите какую размерность массива вы хотите: ");
                            int index = Convert.ToChar(Console.ReadLine());
                            if (ain.ArrayLong(index) != 1) Console.WriteLine("Вы ввели что-то не так :(");
                            else Console.WriteLine("Массив успешно создан!");
                        }
                        break;
                    case 12:
                        {
                            Console.WriteLine("Введите число на которое хотите умножить: ");
                            int multnumb = Convert.ToInt32(Console.ReadLine());
                            if (ain.MultiArray(multnumb) != 0)
                            {
                                for(int i = 0; i < 10; i++)
                                {
                                    Console.WriteLine(ain.MultiArray(multnumb));
                                }
                            }
                            else Console.WriteLine("Что-то не так :(");
                        }
                        break;
                    case 13:
                        {
                            Console.WriteLine("Введите индекс массива от 0 до 9, что бы увидеть соответвующий элемент; так же вы увидете весь массив");
                            int multnumb = Convert.ToInt32(Console.ReadLine());
                            if (ain.AllAndOneIndex(multnumb) != "я тут есть")
                            {
                                Console.WriteLine(ain.AllAndOneIndex(multnumb));
                            }
                            else Console.WriteLine("Что-то не так :(");
                        }
                        break;
                    case 14:
                        {
                            sg.Info();
                        }
                        break;
                    case 15:
                        {
                            Console.WriteLine("Введите признак нужного вам студента");
                            string infa = Console.ReadLine();
                            Console.WriteLine(sg.Search(infa));
                        }
                        break;
                    case 16:
                        {
                            Console.WriteLine("Вы хотите добавить или удалить студента? Введите 1 - добавить, 0 - удалить");
                            int choes = Convert.ToInt32(Console.ReadLine());
                            switch (choes)
                            {
                                case 1:
                                    {
                                        Console.WriteLine("Что бы добавить введите: ");
                                        Console.Write("Индекс - "); string ind = Console.ReadLine();
                                        Console.Write("Группа - "); string gr = Console.ReadLine();
                                        Console.Write("Фамилия - "); string ln = Console.ReadLine();
                                        Console.Write("Имя - "); string nam = Console.ReadLine();
                                        Console.Write("Отчество - "); string ot = Console.ReadLine();
                                        if (sg.AddIndex(ind, gr, ln, nam, ot) == "no") Console.WriteLine("Вы ввели что-то не то или такого студента не существует :(");
                                        else
                                        {
                                            sg.AddIndex(ind, gr, ln, nam, ot);
                                            Console.WriteLine("Вы успешно добавили студента в список!");
                                        }
                                    }
                                    break;
                                case 0:
                                    {
                                        Console.WriteLine("Что бы удалить введите: ");
                                        Console.Write("Индекс - "); string ind = Console.ReadLine();
                                        Console.Write("Группа - "); string gr = Console.ReadLine();
                                        Console.Write("Фамилия - "); string ln = Console.ReadLine();
                                        Console.Write("Имя - "); string nam = Console.ReadLine();
                                        Console.Write("Отчество - "); string ot = Console.ReadLine();
                                        if (sg.RemoveIndex(ind, gr, ln, nam, ot) == "no") Console.WriteLine("Вы ввели что-то не то или такого студента не существует :(");
                                        else
                                        {
                                            sg.RemoveIndex(ind, gr, ln, nam, ot);
                                            Console.WriteLine("Вы успешно удалили студента в список!");
                                        }
                                    }
                                    break;
                                default: Console.WriteLine("Вы ввели не то число"); break;
                            }
                        }
                        break;
                    case 17:
                        {
                            sg.SortList();
                        }
                        break;
                    case 18:
                        {
                            string word = Console.ReadLine();
                            if (py.CountPaper(word) == null) Console.WriteLine("Что-то пошло не так :(");
                            else Console.WriteLine(py.CountPaper(word));
                        }
                        break;
                    default: Console.WriteLine("Вы ввели нечто странное :("); break;


                }
                Console.WriteLine("Если хотите прекратить операции - введите 'STOP', иначе введите 'GO'");
                stopWord = Console.ReadLine();
                Console.WriteLine("");
            }
        }
    }
}
