namespace Application.Services.Authentication
{
    public class AuthenticationServices : IAuthenticationService
    {
        public AuthenticationResult Login(Guid Id, string FirstName, string LastName, string Email, string Password)
        {
            return new AuthenticationResult(Id, FirstName, LastName, Email, "token");
        }

        public AuthenticationResult Register(Guid Id, string FirstName, string LastName, string Email, string Password)
        {
            return new AuthenticationResult(Id, FirstName, LastName, Email, "token");
        }
    }
}
