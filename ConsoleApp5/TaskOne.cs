using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    //1.Напишите программу с классом, в которой есть статический обобщенный метод. Метод не возвращает результат, а аргументом 
    //  методу передается массив с элементами обобщенного типа. При вызове метода выполняется циклическая перестановка элементов 
    //    массива: первый элемент становится вторым, второй элемент становится третьим, и так далее, а последний элемент становится первым.
    public class TaskOne
    {
          public static void metod<T>(T[] array)
          {
               
                T TaskOneObj = array[0];
                for (int i = 0; i < array.Length; i++)
                {
                    if (i+1 == array.Length)
                    { 
                        array[i] = TaskOneObj;
                    }
                    else
                        array[i] = array[i+1];
                }
                for (int i = 0; i < array.Length; i++)
                { 
                    Console.WriteLine(array[i]); 
                }

          }
    }
}
