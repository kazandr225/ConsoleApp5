using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{

    //2. Напишите программу, содержащую обобщенный класс со свойством обобщенного типа.Значением свойства возвращается значение 
    //закрытого поля обобщенного типа.При присваивании значения свойству значение присваивается закрытому полю.
    public class SecondTask<St>
    {
        private St g;

        public SecondTask(St g)
        {
            this.g = g;
        }

        public override string ToString()
        {
            return "Значение: " + g;
        }
        //
    }
}
