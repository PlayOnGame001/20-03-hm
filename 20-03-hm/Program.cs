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
        public double toplivo;
        public double dostavka_prica;
        public double doroga;

        public Truck() { }
        public Truck(double toplivo, double dostavka_prica, double doroga)
        {
            this.toplivo = toplivo;
            this.dostavka_prica = dostavka_prica;
            this.doroga = doroga;
        }
        public void Deliver()
        {
            Console.Write("Ведите количество топлива: ");
            string fl = Console.ReadLine();
            toplivo = Convert.ToDouble(fl);
            Console.Write("Введите дистанцию: ");
            string d = Console.ReadLine();
            doroga = Convert.ToDouble(d);
            dostavka_prica = 0.05 * doroga;
            Console.WriteLine($"Доставка на грузовике\nЦена: {dostavka_prica} в евро");
        }
    }
    class Ship : Transport
    {
        public double toplivo;
        public double dostavka_prica;
        public double doroga;

        public Ship() { }
        public Ship(double toplivo, double dostavka_prica, double doroga)
        {
            this.toplivo = toplivo;
            this.dostavka_prica = dostavka_prica;
            this.doroga = doroga;
        }
        public void Deliver()
        {
            Console.Write("Введите количество топлива: ");
            string fl = Console.ReadLine();
            toplivo = Convert.ToDouble(fl);
            Console.Write("Введите дистанцию: ");
            string d = Console.ReadLine();
            doroga = Convert.ToDouble(d);
            dostavka_prica = 0.5 * doroga;
            Console.WriteLine($"Доставка на корабле\nЦена: {dostavka_prica} в евро");
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
            Console.WriteLine("Дорожная логистика");
        }
    }
    class SeaLogistic : LogisticsApp
    {
        public void ChooseLogistic()
        {
            Console.WriteLine("Морская логистика");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}