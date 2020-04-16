using System;

namespace pattern_chainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            // Authenticator --> Logger --> Compressor
            var encryptor = new Encryptor(null);
            var compressor = new Compressor(encryptor);
            var logger = new Logger(compressor);
            var authenticator = new Authenticator(logger);
            var webServer = new WebServer(authenticator);
            var request = new HttpRequest("admin", "12345");
            webServer.Handle(request);
        }
    }
}
