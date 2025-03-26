using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_plecakowy
{
    internal class Item
    {
        public int Id { get; }
        public int Value { get; }
        public int Weight { get; }

        public Item(int id, int value, int weight)
        {
            Id = id;
            Value = value;
            Weight = weight;
        }
    }
}
