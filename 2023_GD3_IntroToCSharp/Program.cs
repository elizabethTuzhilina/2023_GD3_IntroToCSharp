using GD.Core.Graphics;
using GD.Examples.Classes;
using GD.Interfaces;
using System;
using System.Collections.Generic;

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

            DemoUpgradingPlayers();

            DemoAbstractInterface();  ////////////////////////////////////

            Console.ReadLine();
        }

        private void DemoAbstractInterface()
        {
            //IGenerateRoute route1 = new IGenerateRoute();  //NEVER INSTANCIATE INTERFACE

            IGenerateRoute walkRoute1 = new GenerateWalkingRoute();
            IGenerateRoute drivingRoute1 = new GenerateDrivingRoute();
            GenerateWalkingRoute walkRoute2 = new GenerateWalkingRoute();
        }

        public void PlanRoute(Vector3 start, Vector3 end, IGenerateRoute router)
        {
            List<Vector3> theRoute = router.GetRoute(start, end);
        }

        public void GetAllRoutes(Vector3 start, Vector3 end, List<IGenerateRoute> routers)
        {
            foreach (IGenerateRoute router in routers)
            {
                List<Vector3> theRoute = router.GetRoute(start, end);
                Console.WriteLine($"the route for {start} to {end} is {theRoute}");
            }
        }

        private void DemoUpgradingPlayers()
        {
            //make list for players
            List<Player> pList = new List<Player>();

            //add N players
            pList.Add(new Player("p1", 75, 34, PlayerType.Thief));
            pList.Add(new Player("p2", 98, 56, PlayerType.Mage));
            pList.Add(new Player("p3", 10, 1, PlayerType.Scout));

            //we want to upgrade them

            //promote player type
            //increase and reset max health
        }

        private void DemoEnum()
        {
            Player p1 = new Player("max", 50, 1000, PlayerType.Thief);
            Console.WriteLine(PlayerType.Mage);
            Console.WriteLine((int)PlayerType.Mage);
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