// Garbage 콜렉터가 메모리를 관리함으로 소멸자를 이용해 객체가 종료될떄 특정 기능을 추가하는 것을 지양할 것.
using System;

namespace Destructor
{
    class Cat
    {
        public Cat()
        {
            _name = "";
            _color = "";
        }
        public Cat(string name, string color)
        {
            _name=name;
            _color=color;
        }
        ~Cat()
        {
            Console.WriteLine("{0} : 잘가", _name);
        }
        public string _name;
        public string _color;

        public void Meow()
        {
            Console.WriteLine("{0} : 야옹", _name);
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Cat kitty = new Cat("키티", "하얀색");
            kitty.Meow();
            Console.WriteLine("{0} : {1}", kitty._name, kitty._color);

            Cat nero = new Cat("네로", "검은색");
            nero.Meow();
            Console.WriteLine("{0} : {1}", nero._name, nero._color);
        }
    }
}