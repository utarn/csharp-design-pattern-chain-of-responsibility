namespace pattern_chainOfResponsibility
{
    public class HttpRequest
    {
        public HttpRequest(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public string Username { get; }
        public string Password { get; }

    }
}