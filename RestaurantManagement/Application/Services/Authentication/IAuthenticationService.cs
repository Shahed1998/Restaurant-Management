namespace Application.Services.Authentication
{
    public interface IAuthenticationService
    {
        AuthenticationResult Login (Guid Id, string FirstName, string LastName, string Email, string Password);
        AuthenticationResult Register (Guid Id, string FirstName, string LastName, string Email, string Password);
    }
}
