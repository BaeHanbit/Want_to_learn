using System;
namespace AccessModifier
{
    class WaterHeater
    {
        protected int temperature;
        public void SetTemperature(int temperature)
        {
            if (temperature < -5 || temperature > 42)
            {
                throw new Exeption("Out of Temperature range");
            }
            this.temperature = temperature;
        }
        internal void TurnOnWater()
        {
            System.Console.WriteLine("Turn on water : {0}", temperature);
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            try
            {
                WaterHeater heater = new WaterHeater();
                heater.SetTemperature(20);
                heater.TurnOnWater();

                heater.SetTemperature(-2);
                heater.TurnOnWater();

                heater.SetTemperature(50);
                heater.TurnOnWater();
            }
            catch (Exeption e)
            {
                System.Console.WriteLine(e.Message);
            }
        }
    }
}