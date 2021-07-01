using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Person :BaseMessageBase
    {
       public BaseMessageBase PersonalMessage(string message)
        {
            Console.WriteLine($"My Personal message{message}");
            return new Person();
        }

        public void MyFunc(Func<Person> func)
        {
            func();
        }
    }
}
