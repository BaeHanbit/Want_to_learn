class Mammal
{
    public void Nurse()
    {
        System.Console.WriteLine("Nurse()");
    }
}

class Dog : Mammal
{
    public void Bark()
    {
        System.Console.WriteLine("Bark()");
    }
}

class Cat : Mammal
{
    public void Meow()
    {
        System.Console.WriteLine("Meow()");
    }
}

class MainApp
{
    static void Main(string[] args)
    {
        Mammal mammal = new Dog();
        Dog dog;// what is the difference between above line?

        if (mammal is Dog)
        {
            dog = (Dog)mammal;
            dog.Bark();
        }

        Mammal mammal2 = new Cat();
        Cat cat = mammal2 as Cat;
        if (cat != null)
        {
            cat.Meow();
        }

        Cat cat2 = mammal as Cat;
        if (cat2 != null)
        {
            cat2.Meow();
        }
        else
        {
            System.Console.WriteLine("cat2 is not a cat");
        }
    }
}