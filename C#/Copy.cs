//클래스도 결국은 주소값.(참조 형식)
using System;
namespace Deepcopy
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Shallow Copy");
            {
                MyClass source = new MyClass();
                source.MyField1 = 10;
                source.MyField2 = 20;

                MyClass target = source;
                target.MyField2 = 30;

                Console.WriteLine("{0} {1}", source.MyField1, source.MyField2);
                Console.WriteLine("{0} {1}", target.MyField1, target.MyField2);
            }

            Console.WriteLine("Deep Copy");
            {
                MyClass source = new MyClass();
                source.MyField1 = 10;
                source.MyField2 = 20;

                MyClass target = source.DeepCopy();
                target.MyField2 = 30;

                Console.WriteLine("{0} {1}", source.MyField1, source.MyField2);
                Console.WriteLine("{0} {1}", target.MyField1, target.MyField2);
            }

        }
    }

    class MyClass
    {
        public int MyField1;
        public int MyField2;

        public MyClass DeepCopy()
        {
            MyClass newCopy = new MyClass();
            newCopy.MyField1 = this.MyField1;
            newCopy.MyField2 = this.MyField2;

            return newCopy;
        }
    }


    // .NET 프레임워크의 System NameSpace에는 ICloneable 이라고 하는 인터페이스가 존재합니다.
    // 깊은 복사 기능을 가질 클래스가 닷넷 프레임워크의 다른 유틸리티 클래스나 다른 프로그래머가 작성한 코드와의 호환을 원한다면 이를 상속하는게 좋습니다.
    //ICloneable 인터페이스는 Clone()메소드 하나만 가지고 있습니다.
    class MyClass2 : ICloneable
    {
        public int MyField1;
        public int MyField2;

        public Object Clone()
        {
            MyClass2 newCopy = new MyClass2();
            newCopy.MyField1 = this.MyField1;
            newCopy.MyField2 = this.MyField2;

            return newCopy;
        }
    }
}