namespace Domain.Identity.Request;

public class AuthenticationRequest
{
    public string Email { get; set; }
    public string Password { get; set; }
}