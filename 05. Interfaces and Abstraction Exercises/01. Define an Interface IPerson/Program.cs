using System;

 public class Program
{
    public static void Main(string[] args)
    {
        string name = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());
        IPerson person = new PersonInfo(name, age);
        Console.WriteLine(person.Name);
        Console.WriteLine(person.Age);
    }
}