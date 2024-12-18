using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console1
{
    public partial class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
    }

    public partial class Book
    {
        public void ShowInfo()
        {
            Console.WriteLine("Title: "+ Title);
            Console.WriteLine("Author: " + Author);
            Console.WriteLine("Year: " + Year.ToString());
        }
    }
}
