namespace Blog;

public static class Configuration
{
    public static string JwtKey = "b5fbd81f087ee9024c35f3b6ffdfdda19f1d2465";
    public static SmtpConfiguration Smtp = new();

    public class SmtpConfiguration
    {
        public string Host { get; set; }
        public int Port { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}