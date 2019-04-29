/*
  C#은 객체지향 언어이다.
  닷넷 프레임워크라는 실행환경과 조화되어 동작하며, 닷넷 프레임워크 덕에 OS에 관계없이 동작할 수 있다.
  콘솔과 윈도우, 웹 어플리케이션이다.
  확장자로 .cs를 사용한다.
 */

using System;


class Program
{
    enum Day { Sat, Sun, Mon, Tue, Wed, Thu, Fri };
    public static void Main()
    {
        {
            int a;
            float b;
            double c;
            char d;

            char e = 'A';
            string f = "Karl";
            string g = f + " is smart!";

            int[] h = new int[100];
            int[] i = new int[] { 1, 2, 3, 4 };
            int[] k = { 1, 2, 3, 4 };
            int[,] l = new int[2, 3];
            int[,,] m = new int[2, 3, 4];
            int[][] n = new int[3][];//재그 배열 - 2차원 이상의 배열에서 각 배열의 요소 소가 일정하지 않은 것.

            n[0] = new int[1] { 1 };
            n[1] = new int[2] { 1, 2 };
            n[2] = new int[3] { 1, 2, 3 };
            int[][] o = new int[][] { new int[] { 1 }, new int[] { 1, 2 }, new int[] { 1, 2, 3 } };
            int p = n.Length;
            bool q = true;
            bool r = (p > 1) ? true : false;
        }
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        {
            if (true) { }
            else if (false) { }
            else { }

            int s;
            for (s = 0; s < 2; s++) { }

            while (false) { }

            int[] t = new[] { 100, 200, 300, 400, 500 };
            foreach (int index in t) { }

            int u = 100;
            switch (u)
            {
                case 1:
                    {
                        u = 100;
                        break;
                    }
                case 2:
                    {
                        u = 200;
                        break;
                    }
                default:
                    {
                        u = 1000;
                        break;
                    }
            }
        }
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        A a1;
        a1 = new A();
        A a2 = new A();
        a1._ags = 3;

        B b1 = new B();
        b1[0] = 1;
        b1[1] = 2;
        b1[2] = 3;
        b1[3] = 4;

    }
}

class A
{
    public int _a;
    public int _b;
    char c;
    public A()
    {
        _a = 0;
        _b = 0;
    }
    public A(A a)
    {
        this._a = a._a;
        _b = a._b;
    }
    public char cgs
    {
        get
        {
            return c;
        }
        set
        {
            c = value;
        }
    }
    public int _ags
    {
        get
        {
            return _a;
        }
        set
        {
            _a = value;
        }
    }
    public int add()
    {
        return _a + _b;
    }
}


//indexer - 객체를 배열처럼
class B: A
{
    int[] a = new int[4];
    public int this[int i]
    {
        get
        {
            return a[i];
        }
        set
        {
            a[i] = value;
        }
    }
    public B(int c, int d) : base(a:[0]) { }
}
//●클래스를 상속했을 때 부모클래스와 자식클래스 각각에 생성자가 있는 경우 부모클래스로부터 차레로 생성자가 작동한다.
sealed class C//상속 금지!
{

}
