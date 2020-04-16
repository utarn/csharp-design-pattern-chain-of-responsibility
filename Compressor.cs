using System;

namespace pattern_chainOfResponsibility
{
    public class Compressor : WebHandler
    {
        public Compressor(WebHandler next) : base(next)
        {
        }

        protected override bool DoHandle(HttpRequest request)
        {
            Console.WriteLine("Compressing");
            return false;
        }
    }
}