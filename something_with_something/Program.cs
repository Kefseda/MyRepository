using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace something_with_something
{
    
    class Program
    {
        static int Sum(int x, int y)
        {
            int sum = x + y;
            return sum;
        }
        static public int Mult(int x, int y)
        {
            int sum = x * y;
            return sum;
        }

        bool isAuthorized;

        class User
        {
            private int age;
            public int Age
            {
                get
                {
                    return age;
                }

                set
                {
                    age = value;
                }
            }
            private string name;
            public string Name
            {
                get
                {
                    return name;
                }

                set
                {
                    name = value;
                }
            }
            public string login;
            public string Login
            {
                get
                {
                    return login;
                }

                set
                {
                    login = value;
                }
            }
            public string password;
            public string Password
            {
                get
                {
                    return password;
                }

                set
                {
                    password = value;
                }
            }

            public bool Authorization()
            {
                Console.WriteLine("Введите логин");
                string x = Console.ReadLine();
                Console.WriteLine("Введите пароль");
                string y = Console.ReadLine();

                if (x == login && y == password) return true;
                else return false;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое слагаемое");
            int x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе слагаемое");
            int y = Int32.Parse(Console.ReadLine());
            Console.WriteLine(x + " + " + y +" = " + Sum(x,y));
            Console.WriteLine("Введите первый множитель");
            x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите второй множитель");
            y = Int32.Parse(Console.ReadLine());
            Console.WriteLine(x + " * " + y + " = " + Mult(x, y));

            User user = new User();
            user.Age = 18;
            user.Login = "Glavniy";
            user.Name = "Иван";
            user.Password = "password";

            bool isAuthorized = user.Authorization();
            if (!isAuthorized) Console.WriteLine("Авторизация не удалась");
            else 
            {
                Console.WriteLine("Вы успешно авторизировались");
                Console.WriteLine("Ваше имя: " + user.Name +
                                  " Ваш возраст: " + user.Age);
            }
            Console.ReadKey();
        }

    }
}
