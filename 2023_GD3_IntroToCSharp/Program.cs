using GD.Core.Graphics;
using System;
using System.Security.Permissions;

namespace GD
{
    /// <summary>
    /// Demo code to introduce core C# concepts useful within the module
    /// </summary>
    internal class Program
    {
        private static void Main(string[] args)
        {
            //see README for content description
            Render3D render = new Render3D();
            new Program().Start();
        }

        public void Start()
        {
            int a = 15;
            int b = 50;
            Swap(ref a, ref b);
            // Console.WriteLine("a: " + a + "," + "b: " + b);
            Console.WriteLine($"a:{a}, b:{b} and sum is {a + b}");
            Console.ReadLine();
        }

        public void Swap(ref int x, ref int y)
        {
            int temp = y;
            y = x;
            x = temp;
        }
    }
}