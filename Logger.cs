using System;

namespace pattern_chainOfResponsibility
{
    public class Logger : WebHandler
    {
        public Logger(WebHandler next) : base(next)
        {
        }

        protected override bool DoHandle(HttpRequest request)
        {
            Console.WriteLine("Logging " + request.Username);
            return false;
        }
    }
}