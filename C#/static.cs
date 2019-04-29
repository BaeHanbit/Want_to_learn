using System;

class Global
{
    public static int cnt = 0;
}
class ClassA
{
    public ClassA()
    {
        Global.cnt++;
    }
}
class ClassB
{
    public ClassB()
    {
        Global.cnt++;
    }
}

class MainApp
{
    static void Main()
    {
        Console.WriteLine("Global.cnt : {0}", Global.cnt);
        new ClassA();
        new ClassA();
        new ClassB();
        new ClassB();

        Console.WriteLine("Global.cnt : {0}", Global.cnt);
    }
}