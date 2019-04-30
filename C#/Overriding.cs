class ArmorSuite
{
    public virtual void Initialize()
    {
        System.Console.WriteLine("Armored");
    }
}

class IronMan : ArmorSuite
{
    public override void Initialize()
    {
        base.Initialize();
        System.Console.WriteLine("Repulsor Rays armed");
    }
}

class WarMachine : ArmorSuite
{
    public override void Initialize()
    {
        base.Initialize();
        System.Console.WriteLine("Double-Barrel Cannons armed");
        System.Console.WriteLine("Micro-Rocket Launcher Armed");
    }
}

class mainApp
{
    static void main(string[] args)
    {
        System.Console.WriteLine("Creating ArmorSuite...");
        ArmorSuite armorsuite = new ArmorSuite();
        armorsuite.Initialize();

        System.Console.WriteLine("\nCreating IronMan...");
        ArmorSuite ironman = new IronMan();
        ironman.Initialize();

        System.Console.WriteLine("\nCreating WarMachine...");
        ArmorSuite warmachine = new WarMachine();
        warmachine.Initialize();
    }
}