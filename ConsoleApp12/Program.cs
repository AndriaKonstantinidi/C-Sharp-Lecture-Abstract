//public abstract class Animal
//{
//    public int a { get; set; }
//    public abstract void MakeSound();
//}

//public class dog : Animal
//{
//    public override void MakeSound()
//    {
//        a = 5;
//        Console.WriteLine("dogo");
//    }
//}

//public class cat : Animal
//{
//    public override void MakeSound()
//    {
//        a = 6;
//        Console.WriteLine("miau");
//    }
//}


class Program
{
    static void Main(string[] args)
    {
        A Jump = new A();
        Jump.AbilitiesList();

        B Sprint = new B();
        Sprint.AbilitiesList();

        C Fly = new C();
        Fly.AbilitiesList();
    }
}

public abstract class ABC
{
    public int a { get; set; }
    public abstract void AbilitiesList();
}

public class A : ABC
{
    
    public override void AbilitiesList()
    {
        a = 1;
        Console.WriteLine(a+" "+"Can jump");
    }
}

public class B : ABC
{
    public override void AbilitiesList()
    {
        a = 2;
        Console.WriteLine(a+" "+"Can Sprint");
    }
}

public class C : ABC
{
    public override void AbilitiesList()
    {
        a = 3;
        Console.WriteLine(a+" "+"Can Fly");
    }
}