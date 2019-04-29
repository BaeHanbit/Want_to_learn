// Sealed 한정자를 통해 상속을 봉인하는 것이 가능하다.
class Base
{
    protected string Name;
    public Base(string Name)
    {
        this.Name = Name;
        System.Console.WriteLine("{0}.Base()", this.Name);
    }
    ~Base()
    {
        System.Console.WriteLine("{0}.~Base()", this.Name);
    }
    public void BaseMethod()
    {
        System.Console.WriteLine("{0}.BaseMethod()", Name);
    }
}

class Derived : Base
{
    public Derived(string Name) : base(Name)
    {
        System.Console.WriteLine("{0}.Derived()", this.Name);
    }

    ~Derived()
    {
        System.Console.WriteLine("{0}.~Derived()", this.Name);
    }

    public void DerivedMethod()
    {
        System.Console.WriteLine("{0}.DerivedMethod()", Name);
    }
}

class MainApp
{
    static void Main(string[] args)
    {
        Base a = new Base("a");
        a.BaseMethod();

        Derived b = new Derived("b");
        b.BaseMethod();
        b.DerivedMethod();
    }
}