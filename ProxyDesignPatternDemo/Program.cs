using ProxyDesignPatternDemo.Model;

public class Program
{
    public static void PrintDetails(Person person)
    {
        Console.WriteLine(person);
    }
    static void Main(string[] args)
    {
        Person person1=new Person("Ram","Admin");
        Person person2= new Person("Shyam", "User");

        PrintDetails(person1);
        ProxyDatabase proxyDatabase1=new ProxyDatabase(person1);
        proxyDatabase1.UpdateDatabase();

        Console.WriteLine();

        PrintDetails(person2);
        ProxyDatabase proxyDatabase2 = new ProxyDatabase(person2);
        proxyDatabase2.UpdateDatabase();
    }
}