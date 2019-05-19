using System;

namespace DesignPatterns.Creational.Factory
{
    public class Program
    {
        static void main(string[] args)
        {
            var middlewayFactory = new MiddlewareFactory();
            IMiddleware middleware = middlewayFactory.GetMiddleware(1);
            middleware.DoAction();
            middleware = middlewayFactory.GetMiddleware(2);
            middleware.DoAction();
            Console.Read();
        }

    }
}
