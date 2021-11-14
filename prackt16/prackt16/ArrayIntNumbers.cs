using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prackt16
{
    class ArrayIntNumbers
    {
        //обращение к отдельному элементу 
        //возможность задать размерность массива при создании (сложение вычитания массивов?)
        //умножение элементов массива на конкретное число
        //вывод на консоль элемента массива по индексу/ всего массива
        Random rnd = new Random();
        public int OneIndex(int index)
        {
            int[] arr = new int[100];
            for(int i = 0; i < 100; i++)
            {
                arr[i] = rnd.Next(0, 100);
            }
            if (index < 100 && index >= 0) return arr[index];
            else return 0;
        }
        //не понял условия функции, так что просто будет массив с нужным индексом
        public int ArrayLong(int index)
        {
            int[] newArr = new int[index];
            return 1;
        }

        public int MultiArray(int numb)
        {
            int[] arr = new int[10];
            for (int i = 0; i < 10; i++)
            {
                arr[i] = rnd.Next(0, 10);
            }
            for(int j = 0; j < 10; j++)
            {
                arr[j] *= numb;
                return arr[j];
            }
            return 0;
        }
        public string AllAndOneIndex(int index)
        {
            int[] arr = new int[10];
            string answer = "";
            for (int i = 0; i < 10; i++)
            {
                arr[i] = rnd.Next(0, 100);
                answer += arr[i].ToString() + "\n";
            }
            if (index < 10 && index >= 0) return answer + "Выбранное число: " + arr[index].ToString();
            else return "я тут есть";
        }

    }
}
