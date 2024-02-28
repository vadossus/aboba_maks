using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Monster
    {
        public string name;
        int hp;
        int damage;
        int critical_damage;
        static Random r = new Random();

        static string[] harast = new string[6] { "Добрый", "Славный", "Кусачий", "Злой", "Бешеный","Тупой" };
        static string[] names = new string[6] { "Гоблин", "Рыцарь", "Злыдень", "Водяной", "Воин","Петух" };

        public void Create_name()
        {
            name = names[r.Next(6)] + " " + harast[r.Next(6)];
        }
        public int get_hp()
        {
            return hp;
        }
        public void set_hp()
        {
            hp = r.Next(50, 100);
        }

        public int Damage()
        {
            damage = r.Next(10, 20);
            return damage;
        }

        public string DrawMonster()
        {
            return $"+----------{name}\n| Здоровье: {hp}\n| Урон: {damage}\n+----------";
        }

        public int Fight(int damage)
        {
            int total_damage = damage + critical_damage;
            hp = hp - total_damage;
            return hp;
        }

        public int CriticalDamage()
        {
            critical_damage = r.Next(0, 3);
            critical_damage = damage * critical_damage;
            return critical_damage;
        }

        public int Promax()
        {
            damage = 0;
            critical_damage = 0;
            hp = hp;
            Console.WriteLine("Промахнулся");
            return damage;
            
        }

        public int Random()
        {
            int chance = r.Next(1, 3);
            return chance;
        }

        public int Total()
        {
            int total = damage + critical_damage;
            return total;
        }
    }
}
