//분할 클래스랑 여러번에 나눠서 구현하는 클래스를 말한다.
// 그 자체로 특별한 기능을 가지는 것이 아닌, 클래스의 구현이 길어질 때 여러 파일에 나눠서 구현할 수 있게 함으로써
// 소스 코드 관리의 편의를 제공하는 데 그 의미가 있습니다.

partial class MyClass
{
    public void Method1()
    {
        System.Console.WriteLine("1");
    }
    public void Method2()
    {
        System.Console.WriteLine("2");
    }
}

class MainApp
{
    static void Main(string[] args)
    {
        MyClass obj = new MyClass();
        obj.Method1();
        obj.Method2();
        obj.Method3();
        obj.Method4();
    }
}

partial class MyClass
{
    public void Method3()
    {
        System.Console.WriteLine("3");
    }
    public void Method4()
    {
        System.Console.WriteLine("4");
    }
}