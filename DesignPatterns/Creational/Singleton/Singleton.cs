﻿namespace DesignPatterns.Creational
{
    //not thread safe
    public class Singleton
    {
        private static Singleton _instance;
        private Singleton()
        {
            
        }

        public static Singleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Singleton();
                }
                return _instance;
            }
        }
    }
    
}
