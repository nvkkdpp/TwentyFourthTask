using System;

namespace TwentyFourthTask
{
    public class MyObject
    {
        private static MyOtherObject _staticObj = new MyOtherObject();
        private MyOtherObject _dynamicObj;
        public MyObject()
        {
            Console.WriteLine("Начало конструктора MyObject");
            Console.WriteLine("(Статистические члены-данные конструируются до этого конструктора)");
            Console.WriteLine("Теперь динамически создаём нестатические члены-данные:");
            _dynamicObj = new MyOtherObject();
            Console.WriteLine("MyObject constructor ending");
        }
    }
    public class MyOtherObject
    {
        public MyOtherObject()
        {
            Console.WriteLine("Конструирование MyOtherObject");
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Начало метода Main()");
            Console.WriteLine("Создание локального объекта MyObject в Main():");
            MyObject localObject = new MyObject();
            Console.WriteLine("Функция конструктора была успешно произведена");
            Console.WriteLine("Нажмите <enter> для завершения программы . . .");
            Console.Read();
        }
    }
}
