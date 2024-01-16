using System;

class Program
{
    static void Main()
    {
        // fixa användarnamnet
        Console.Write("Ange ditt användarnamn: ");
        string användarnamn = Console.ReadLine();
        if (användarnamn == "noname")
        {
            Console.WriteLine("Welcome");
        }
    }
}
