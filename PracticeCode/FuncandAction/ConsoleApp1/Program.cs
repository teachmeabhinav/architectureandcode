using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<Person, BaseMessageBase> func= funcImplementaion;
            funcImplementaion(new Person { message = "testc" });
            Person pp = new Person();
            Func<Person> func11 = funcImplementaionCallBack;
            pp.MyFunc(func11);
        }
        static BaseMessageBase funcImplementaion(Person p)
        {
           return  p.PersonalMessage("Yes");

        }
        static Person funcImplementaionCallBack()
        {
            Person p = new Person();
             p.PersonalMessage("funcImplementaionCallBack");
            return p;

        }
    }

}
