using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console1
{
    public class Dragon : IEnemy
    {
        public void Attack()
        {
            Console.WriteLine("Dragon breathes fire and deals damage.");
        }

        public void Defend()
        {
            Console.WriteLine("Dragon closes it's wings to defend.");
        }
    }
}
