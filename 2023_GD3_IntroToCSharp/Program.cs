using GD.Core.Graphics;
using GD.Examples.Classes;
using System;

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
            DemoStringInterpolation();
            DemoPassByReference();

            //DemoProperties();
            DemoHashEquals();
            //   DemoDeepShallow();
            DemoEnum();

            Console.ReadLine();
        }

        private void DemoEnum()
        {
            Player p1 = new Player("max", 50, 1000, "scout");
        }

        private void DemoDeepShallow()
        {
            throw new NotImplementedException();
        }

        private void DemoStringInterpolation()
        {
            int a = 15;
            int b = 50;
            // Console.WriteLine("a: " + a + "," + "b: " + b);
            Console.WriteLine($"a:{a}, b:{b} and sum is {a + b}");
        }

        private void DemoPassByReference()
        {
            int a = 15;
            int b = 50;
            Swap(ref a, ref b);
        }

        private void DemoProperties()
        {
            throw new NotImplementedException();
        }

        private void DemoHashEquals()
        {
            //equals
            Vector3 newPickup = new Vector3(1, 2, 3);

            Vector3 currentPickup = new Vector3(10, 20, 30);

            if (newPickup.Equals(""))
                Console.WriteLine("Same vector3!");
            else
                Console.WriteLine("Different vector3!");
        }

        public void Swap(ref int x, ref int y)
        {
            int temp = y;
            y = x;
            x = temp;
        }
    }
}