using Class05.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class05.Models
{
    public class Rune : IMagic
    {
        public string Name { get; set; }
        public int Sorcery { get; set; }

        public Rune(string name, int power)
        {
            Name = name;
            Sorcery = sorcery;
        }
    }
}
