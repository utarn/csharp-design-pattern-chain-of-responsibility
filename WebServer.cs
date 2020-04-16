namespace pattern_chainOfResponsibility
{
    public class WebServer
    {
        private readonly WebHandler _handler;

        public WebServer(WebHandler handler)
        {
            _handler = handler;
        }

        public void Handle(HttpRequest request)
        {
            _handler.Handle(request);
        }
    }
}