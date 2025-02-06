namespace Day9Assignment1.Services
{
    public interface IUserService
    {
        Task<bool> Register(string username, string password);
        Task<bool> Authenticate(string username, string password);
    }
}
