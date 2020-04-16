namespace pattern_chainOfResponsibility
{
    public abstract class WebHandler
    {
        private readonly WebHandler _next;

        public WebHandler(WebHandler next)
        {
            _next = next;
        }

        public void Handle(HttpRequest request)
        {
            if (DoHandle(request))
                return;

            if (_next != null)
                _next.Handle(request);
        }

        protected abstract bool DoHandle(HttpRequest request);
    }
}