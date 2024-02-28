using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static Random r = new Random();
        static void Main(string[] args)
        {
            Monster monster = new Monster();
            Monster monster2 = new Monster();
            Console.WriteLine("Добро пожаловать в игру: Монстер!");
            Console.WriteLine("Ваша задача, отпинать другого монстра");
            Console.WriteLine("Ваш персонаж: ");
            monster.Create_name();
            monster.set_hp();
            monster.get_hp();
            monster.Damage();
            Console.WriteLine(monster.DrawMonster());

            Console.WriteLine("Чужак: ");
            monster2.Create_name();
            monster2.set_hp();
            monster2.get_hp();
            monster2.Damage();
            Console.WriteLine(monster2.DrawMonster());

            Console.WriteLine("Хотите начать бой?: ");
            int b = Convert.ToInt32(Console.ReadLine());

            

            if (b == 1)
            {
                Console.WriteLine("Битва началась!");
                int i = 0;
                while (monster.get_hp() > 0 && monster2.get_hp() > 0)
                {
                    Console.WriteLine("----------------");
                    Console.WriteLine($"Здоровье персонажа {monster.name}: {monster.Fight(monster2.Total())}");
                    monster.Random();
                    if (monster.Random() == 1 || monster.Random() == 2)
                    {
                        Console.WriteLine($"Ваш урон {monster.Damage()} c критическим уроном {monster.CriticalDamage()}");
                        Console.WriteLine($"Итого: {monster.Total()}");
                    }   
                    else
                    {
                        monster.Promax();
                    }
                    Console.WriteLine("----------------");
                    Console.WriteLine(" ");
                    Thread.Sleep(3000);
                    Console.WriteLine(" ");
                    Console.WriteLine("----------------");
                    Console.WriteLine($"Здоровье чужака {monster2.name}: {monster2.Fight(monster.Total())}");
                    monster2.Random();
                    if (monster2.Random() == 1 || monster2.Random() == 2)
                    {
                        Console.WriteLine($"Урон чужака: {monster2.Damage()} с критическим уроном {monster2.CriticalDamage()}");
                        Console.WriteLine($"Итого: {monster2.Total()}");
                    }                
                    else
                    {
                        monster2.Promax();
                    }
                    Console.WriteLine("----------------");

                    
                }
                Console.WriteLine("Конец!");
            }
            else
            {
                Console.WriteLine("До свидания");
                Environment.Exit(0);
            }

            Console.Read();
        }

        
    }
}
