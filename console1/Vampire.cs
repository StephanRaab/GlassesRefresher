using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console1
{
    public class Vampire : IEnemy
    {
        public void Attack()
        {
            Console.WriteLine("Vampire sinks their fangs in the neck and drains your life energy.");
        }

        public void Defend()
        {
            Console.WriteLine("Vampire becomes a bat to evade your attacks.");
        }
    }
}
