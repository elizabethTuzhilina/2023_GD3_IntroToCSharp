using GD.Examples.Classes;
using System;
using System.Collections.Generic;

namespace GD.Interfaces
{
    //an interface is ABSTRACT - we never instanciate - it has no VARS and NO METHOD BODIES
    public interface IGenerateRoute
    {
        List<Vector3> GetRoute(Vector3 start, Vector3 end);
    }

    public class GenerateDrivingRoute : IGenerateRoute
    {
        public List<Vector3> GetRoute(Vector3 start, Vector3 end)
        {
            Console.WriteLine("Getting driving interface...");
            return null;
        }
    }

    public class GenerateWalkingRoute : IGenerateRoute
    {
        public List<Vector3> GetRoute(Vector3 start, Vector3 end)
        {
            Console.WriteLine("Getting walking interface...");
            return null;
        }
    }
}