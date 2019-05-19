using System;
using System.Collections.Generic;

namespace DesignPatterns.Creational.Factory
{
    public class MiddlewareFactory
    {
        private Dictionary<string, Type> autos;
        public IMiddleware GetMiddleware(int which)
        {
            //Values normally read in from a config file
            switch (which)
            {
                case 1:
                    return new Middleware1();
                case 2:
                    return new Middleware2();
                default:
                    return null;
            }
        }

       
    }
}