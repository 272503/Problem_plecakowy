using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
[assembly: InternalsVisibleTo("Plecak_Test")]
namespace Problem_plecakowy
{
    internal class Problem
    {
        public int ItemAmount { get; }
        public List<Item> Items { get; }

        public Problem(int n, int seed)
        {
            ItemAmount = n;

            Random random = new Random(seed);

            Items = new List<Item>();

            for (int i = 0; i < ItemAmount; i++)
            {
                Items.Add(new Item(i + 1, random.Next(1, 11), random.Next(1, 11)));
            }
        }

        public Result Solve(int capacity)
        {
            var sortedItems = Items.OrderByDescending(i => (double)i.Value / i.Weight).ToList();
            Result result = new Result();

            foreach (var item in sortedItems)
            {
                if (result.TotalWeight + item.Weight <= capacity)
                {
                    result.UsedItems.Add(item.Id);
                    result.TotalValue += item.Value;
                    result.TotalWeight += item.Weight;
                }
            }
            return result;

        }
        public override string ToString()
        {
            return string.Join("\n", Items.Select(i => $"Item {i.Id}: Value={i.Value}, Weight={i.Weight}"));
        }
    }
}
