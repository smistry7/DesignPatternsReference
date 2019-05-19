using System;

namespace DesignPatterns.Creational.Factory
{
    public class Middleware2 : IMiddleware
    {
        public void DoAction()
        {
            Console.WriteLine("Executing action from Middleware2");
        }
    }
}