using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_03_hm
{
    interface Transport
    {
        void Deliver();
    }
    class Truck : Transport
    {
        public double fuel_consumption;
        public double deliver_price;
        public double distance;

        public Truck() { }
        public Truck(double fuel_consumption, double deliver_price, double distance)
        {
            this.fuel_consumption = fuel_consumption;
            this.deliver_price = deliver_price;
            this.distance = distance;
        }
        public void Deliver()
        {
            Console.Write("Enter fuel consumption: ");
            string fl = Console.ReadLine();
            fuel_consumption = Convert.ToDouble(fl);
            Console.Write("Enter distance: ");
            string d = Console.ReadLine();
            distance = Convert.ToDouble(d);
            deliver_price = 0.05 * distance;
            Console.WriteLine($"Delivered by truck\nPrice: {deliver_price} euro");
        }
    }
    class Ship : Transport
    {
        public double fuel_consumption;
        public double deliver_price;
        public double distance;

        public Ship() { }
        public Ship(double fuel_consumption, double deliver_price, double distance)
        {
            this.fuel_consumption = fuel_consumption;
            this.deliver_price = deliver_price;
            this.distance = distance;
        }
        public void Deliver()
        {
            Console.Write("Enter fuel consumption: ");
            string fl = Console.ReadLine();
            fuel_consumption = Convert.ToDouble(fl);
            Console.Write("Enter distance: ");
            string d = Console.ReadLine();
            distance = Convert.ToDouble(d);
            deliver_price = 0.5 * distance;
            Console.WriteLine($"Delivered by ship\nPrice: {deliver_price} euro");
        }
    }

    interface LogisticsApp
    {
        void ChooseLogistic();
    }
    class RoadLogistic : LogisticsApp
    {
        public void ChooseLogistic()
        {
            Console.WriteLine("It's road logistic");
        }
    }
    class SeaLogistic : LogisticsApp
    {
        public void ChooseLogistic()
        {
            Console.WriteLine("It's sea logistic");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}