using JAMK.IT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labra4_tehtava_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            Boss boss = new Boss();

            boss.Nimi = "Teppo Tulppu";
            boss.Palkka = 2000f;
            boss.Ammatti = "Peltiseppä";
            boss.PalkkaBonus = 200f;
            boss.Auto ="Ferraaari";

            employee.Nimi = "Jaakko Teppo";
            employee.Palkka = 2000f;
            employee.Ammatti = "Peltiseppä";

            Console.WriteLine(employee.ToString());
            Console.WriteLine(boss.ToString());


        }
    }
}
