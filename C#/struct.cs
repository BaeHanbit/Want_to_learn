// 문법적으로 구조체와 클래스가 유사한것은 사실이지만, 객체를 추상화하기 위한 클래스와 데이터를 담기 위한 자료구조인 구조체의
// 존재이유는 다르다 볼 수 있다.
// 구조체는 값 형식임으로 GC의 사용을 줄이는 이점을 가진다
// 구조체의 각 필드는 CLR이 기본값으로 초기화를 한다.

struct Point3D
{
    public int X;
    public int Y;
    public int Z;

    public Point3D(int X, int Y, int Z)
    {
        this.X = X;
        this.Y = Y;
        this.Z = Z;
    }

    public override string ToString()
    {
        return string.Format("{0}, {1}, {2}", X, Y, Z);
    }
}

class MainApp
{
    static void Main(string[] args)
    {
        Point3D p3d1;
        p3d1.X = 10;
        p3d1.Y = 20;
        p3d1.Z = 30;

        System.Console.WriteLine(p3d1.ToString());

        Point3D p3d2 = new Point3D(100, 200, 300);
        Point3D p3d3 = p3d2;
        p3d3.Z = 400;

        System.Console.WriteLine(p3d2.ToString());
        System.Console.WriteLine(p3d3.ToString());
    }
}
