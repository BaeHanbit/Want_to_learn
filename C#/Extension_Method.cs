//확장 메소드(Extension Method)는 상속과는 다른 기존 클래스의 기능을 확장하는 기법이다.
public static class MyExtension
{
    public static int Square(this int MyInt)
    {
        return MyInt*MyInt;
    }

    public static int Power(this int MyInt, int Exponent)
    {
        int result = MyInt;
        for(int i=1;i<Exponent;i++)
        {
            result*=MyInt;
        }
        return result;
    }
}

class MainApp
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("{0}^2 : {1}",3,3.Square());
        System.Console.WriteLine("{0}^{1} : {2}",3,4,3.Power(4));
        System.Console.WriteLine("{0}^{1} : {2}",2,10,2.Power(10));
    }
}