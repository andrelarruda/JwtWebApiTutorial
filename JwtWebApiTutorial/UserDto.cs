namespace JwtWebApiTutorial
{
    // This class will be used in the login. To store the username and password given by the login client.
    public class UserDto
    {
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    } 
}
