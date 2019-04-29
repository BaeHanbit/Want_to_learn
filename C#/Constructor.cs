// 컴파일러가 기본 생성자를 제공하지 않는경우
// 프로그래머가 생성자를 하나라도 직접 정의하면 C# 컴파일러는 매개변수 없는 기본 생성자를 제공하지 않는다.
using System;

namespace test_cppp
{
    class test_program
    {
        static void Main(string[] args)
        {
            Cat kitty = new Cat();
            kitty.Name = "키티";
            kitty.Color = "하얀색";

            Cat nabi = new Cat("나비", "갈색");
        }
    }

     class Cat
    {
        public Cat()
        {
            Name = "";
            Color = "";
        }
        public Cat(string _Name, string _Color)
        {
            Name = _Name;
            Color = _Color;
        }
        public string Name;
        public string Color;
    }
}
