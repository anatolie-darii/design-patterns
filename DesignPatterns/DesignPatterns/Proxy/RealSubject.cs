﻿namespace DesignPatterns.Proxy
{
    internal class RealSubject : ISubject
    {
        public string DoAction(string message)
        {
            return "Message send by subject";
        }
    }
}