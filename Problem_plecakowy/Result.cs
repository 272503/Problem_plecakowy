using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
[assembly: InternalsVisibleTo("Plecak_Test")]
namespace Problem_plecakowy
{
    internal class Result
    {
        public List<int> UsedItems { get; } = new List<int>();
        public int TotalValue { get; set; }
        public int TotalWeight { get; set; }

        public override string ToString()
        {
            return $"Items: {string.Join(",", UsedItems)}, Value: {TotalValue}, Weight: {TotalWeight}";
        }

    }
}
