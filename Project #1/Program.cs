using System;
using System.Collections.Generic; // <----
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Project__1
{
    public class Tanks
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public int Armour { get; set; } // Value % 1 = Paper  100 = Iron Wall
        public int Damage { get; set; } // Value 10 = small Penetration  1000 = Boom !
        public Tanks(string type, string name, int armour, int damage)
        {
            Type = type;
            Name = name;
            Armour = armour;
            Damage = damage;
        }
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Welcome to the Testing area");
                // adds up some M-Tanks
                Tanks Tank1 = new Tanks("MediumTank", "Strv 122B", 10000, 550);
                Tanks Tank2 = new Tanks("MediumTank", "Leopard 2", 10000, 600);
                Tanks Tank3 = new Tanks("MediumTank", "M1A2 SEP", 10000, 480);
                Tanks Tank4 = new Tanks("MediumTank", "Challanger 3", 10000, 548);
                Tanks Tank5 = new Tanks("MediumTank", "T 80", 10000, 600);

                // adds up some Tank Destroyers
                Tanks Tank6 = new Tanks("TankDestroyer", "Jagdpanzer IV", 5000, 900);
                Tanks Tank7 = new Tanks("TankDestroyer", "ISU-152", 5000, 850);
                Tanks Tank8 = new Tanks("TankDestroyer", "T28", 5000, 700);

                //  BattleGround // Last Tank Standing
                try
                {
                    if ( Tank1.Damage > Tank6.Damage)
                    {
                        Console.WriteLine($"{Tank1.Name} is a Winner with type {Tank1.Type}");
                        Tank6.Armour -= Tank1.Damage;
                    }
                    else
                    {
                        Console.WriteLine($"{Tank6.Name} is a Winner with type {Tank6.Type}");
                        Tank1.Armour -= Tank6.Damage;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("Control101: ¨Battle has been without any problems, Over¨");
                    Console.WriteLine(Tank1.Armour);
                    Console.WriteLine(Tank6.Armour);
                }
                Console.ReadKey();
            }
        }
    }
}
