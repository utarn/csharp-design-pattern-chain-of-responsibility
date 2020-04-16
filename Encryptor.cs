using System;

namespace pattern_chainOfResponsibility
{
    public class Encryptor : WebHandler
    {
        public Encryptor(WebHandler next) : base(next)
        {
        }

        protected override bool DoHandle(HttpRequest request)
        {
            Console.WriteLine("Encrypting");
            return false;
        }
    }
}