using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Основной поток начал работу.");

        Parallel.Invoke(Method1, Method2);
        //Method1();
        //Method2();
        Console.WriteLine("Основной поток завершил работу.");
        Console.ReadLine();
    }

    static void Method1()
    {
        Console.WriteLine("Метод 1 начал работу.");
        //Thread.Sleep(2000);
        Console.WriteLine("Метод 1 завершил работу.");
    }

    static void Method2()
    {
        Console.WriteLine("Метод 2 начал работу.");
        //Thread.Sleep(2000);
        Console.WriteLine("Метод 2 завершил работу.");
    }

    static void Method3()
    {
        Console.WriteLine("Метод 3 начал работу.");
        Thread.Sleep(2000);
        Console.WriteLine("Метод 3 завершил работу.");
    }
    }
