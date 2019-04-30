class Base
{
    public void Mymethod()
    {
        System.Console.WriteLine("Base.Mymethod");
    }
}

class Derived : Base
{
    public new void Mymethod()
    {
        System.Console.WriteLine("Derived.Mymethod");
    }
}

class MainApp
{
    static void Main(string[] args)
    {
        Base baseObj = new Base();
        baseObj.Mymethod();

        Derived derivedObj = new Derived();
        derivedObj.Mymethod();

        Base baseOrDerived = new Derived();
        baseOrDerived.Mymethod();
    }
}