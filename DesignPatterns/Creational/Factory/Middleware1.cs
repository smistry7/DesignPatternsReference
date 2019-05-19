using System;

namespace DesignPatterns.Creational.Factory
{
    public class Middleware1 : IMiddleware
    {
        public void DoAction()
        {
            Console.WriteLine("Executing action from Middleware1");
        }
    }
}