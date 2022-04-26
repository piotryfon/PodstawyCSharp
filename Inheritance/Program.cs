using System;
using System.Threading;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Ferrari ferrari_F40 = new(300, 280, 2, 3.4);
            ferrari_F40.Work();
            ferrari_F40.Start();
            int vmax = ferrari_F40.VMax;
            Thread.Sleep(1000);
            Console.WriteLine("Max speed " + vmax);

           
        }
    }
    abstract class Vehicle
    {
        public Vehicle(int power, int vMax)
        {
            Poweer = power;
            VMax = vMax;
        }
      
        public int Poweer { get; set; }
        public int VMax { get; set; }
    }
    abstract class Car : Vehicle
    {
        public Car(int power, int vMax, int numberOfSeats) : base(power, vMax)
        {
            NumberOfSeats = numberOfSeats;
        }
        public int NumberOfSeats { get; set; }
        public virtual void Work()
        {
            Console.WriteLine("Brum brum...");
        }
        public abstract void Start(); // metoda abstract wymusza jej implementację w klacie podrzędnej
    }
    class Ferrari : Car
    {
        public Ferrari(int power, int vMax, int numberOfSeats, double acceleration) : base(power, vMax, numberOfSeats)
        {
            Acceleration = acceleration;
        }

        public double Acceleration { get; set; }

        public override void Start()
        {
            Console.WriteLine("Go!");
        }

        public override void Work()
        {
            base.Work(); // dziedziczy bazę
            Console.WriteLine("Wrrrr...");
        }
    }
}
