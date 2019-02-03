using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vjezba2
{
    class Program
    {
        static void Main(string[] args)
        {
        Kugla.IspisiPodatke();

        List<GeometrijskiLikovi> likovi = new List<GeometrijskiLikovi>();
        likovi.Add(new Kvadrat(1));
        likovi.Add(new Trokut(2));
        likovi.ForEach(Console.WriteLine);
        Console.ReadLine();
    }
}
}
