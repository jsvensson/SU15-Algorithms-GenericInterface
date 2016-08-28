using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Set;

namespace SetDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var setA = new Set<int> {1, 2, 3, 4, 5};
            var setB = new Set<int> {4, 5, 6, 7, 8};

            Console.WriteLine($"Creating setA: {setA}");
            Console.WriteLine($"Creating setB: {setB}");
            Console.WriteLine();

            Console.WriteLine($"setA.Count: {setA.Count}");
            setA.Add(42);
            Console.WriteLine($"setA.Add(42): {setA}");
            Console.WriteLine($"setA.Count: {setA.Count}");
            setA.Remove(42);
            Console.WriteLine($"setA.Remove(42): {setA}");
            Console.WriteLine($"setA.Count: {setA.Count}");
            Console.WriteLine();

            Console.WriteLine($"setA.Contains(3): {setA.Contains(3)}");
            Console.WriteLine($"setA.Contains(42): {setA.Contains(42)}");
            Console.WriteLine();

            Console.WriteLine($"setA.EqualTo(setA): {setA.EqualTo(setA)}");
            Console.WriteLine($"setA.EqualTo(setB): {setA.EqualTo(setB)}");
            Console.WriteLine();

            var setC = setA.Copy();
            Console.WriteLine($"setC = setA.Copy(): {setC}");
            Console.WriteLine($"setA.EqualTo(setC): {setA.EqualTo(setC)}");
            Console.WriteLine();

            Console.WriteLine($"setA.UnionWith(setB): {setA.UnionWith(setB)}");
            Console.WriteLine($"setA.UnionWith(setC): {setA.UnionWith(setC)}");
            Console.WriteLine();

            Console.WriteLine($"setA.IntersectionWith(setB): {setA.IntersectionWith(setB)}");
            Console.WriteLine();
        }
    }
}
