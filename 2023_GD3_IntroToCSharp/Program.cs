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
            DemoStringInterpolation();
            DemoPassByReference();

            DemoProperties();
            DemoHashEquals();
            DemoDeepShallow();

            Console.ReadLine();
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
            throw new NotImplementedException();
        }

        public void Swap(ref int x, ref int y)
        {
            int temp = y;
            y = x;
            x = temp;
        }
    }
}