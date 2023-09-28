﻿using GD.Controller;
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
            //core
            DemoStringInterpolation();
            DemoPassByReference();
            DemoProperties();
            DemoHashEquals();
            DemoEnum();

            //design pattern related
            DemoAbstractFactoryPattern();
            DemoStrategyPattern();

            //a pause to stop the command prompt closing
            Console.ReadLine();
        }

        private void DemoStrategyPattern()
        {
            Player p1 = new Player("p1", 75, 34, PlayerType.Thief);

            //use the controller...
            GameObjectUpgradeController playerUpgradeController
                = new GameObjectUpgradeController();

            playerUpgradeController.Add(new UpgradePlayerHealth(200));
            playerUpgradeController.Add(new UpgradePlayerType());

            playerUpgradeController.Upgrade(p1);
        }

        private void DemoAbstractFactoryPattern()
        {
            //IGenerateRoute route1 = new IGenerateRoute();  //NEVER INSTANCIATE INTERFACE

            //notice how we store a child (class that implements interface) as a variable of type IGenerateRoute => polymorphism
            IGenerateRoute walkRoute1 = new GenerateWalkingRoute();
            IGenerateRoute drivingRoute1 = new GenerateDrivingRoute();

            //we could store the child as a variable (i.e. walkRoute2) of type child (i.e. GenerateWalkingRoute) but this is less flexible
            GenerateWalkingRoute walkRoute2 = new GenerateWalkingRoute();

            //define the start and end
            Vector3 start = new Vector3(1, 2, 3);
            Vector3 end = new Vector3(40, 50, 60);

            //calculcate the driving route
            PlanRoute(start, end, drivingRoute1);

            //calculcate the walking route
            PlanRoute(start, end, walkRoute1);

            //a fast way to add objects to a list (as opposed to using Add())
            List<IGenerateRoute> routers = new List<IGenerateRoute>
            {
                 new GenerateDrivingRoute(),
                 new GenerateWalkingRoute()
            };
            // routers.Add(new GenerateDrivingRoute());

            //calculate the route for all modes of transport (walk, drive)
            GetAllRoutes(start, end, routers);
        }

        public void PlanRoute(Vector3 start, Vector3 end, IGenerateRoute router)
        {
            List<Vector3> theRoute = router.GetRoute(start, end);
            Console.WriteLine($"the route for {start} to {end} is {theRoute}");
        }

        public void GetAllRoutes(Vector3 start, Vector3 end, List<IGenerateRoute> routers)
        {
            foreach (IGenerateRoute router in routers)
            {
                List<Vector3> theRoute = router.GetRoute(start, end);
                Console.WriteLine($"the route for {start} to {end} is {theRoute}");
            }
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
            Player p1 = new Player("max", 100, 50, PlayerType.Mage);

            //setting using property
            p1.Health = 35;

            //getting using property
            Console.WriteLine(p1.Name);
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

/*
     //make list for players
            List<Player> pList = new List<Player>();

            //add N players
            pList.Add(new Player("p1", 75, 34, PlayerType.Thief));
            pList.Add(new Player("p2", 98, 56, PlayerType.Mage));
            pList.Add(new Player("p3", 10, 1, PlayerType.Scout));
 */