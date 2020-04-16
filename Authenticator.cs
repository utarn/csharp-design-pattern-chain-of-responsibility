using System;

namespace pattern_chainOfResponsibility
{
    public class Authenticator : WebHandler
    {
        public Authenticator(WebHandler next) : base(next)
        {
        }

        protected override bool DoHandle(HttpRequest request)
        {
            Console.WriteLine("Authenticating");
            return !(request.Username == "admin" && request.Password == "1234");
        }
    }
}