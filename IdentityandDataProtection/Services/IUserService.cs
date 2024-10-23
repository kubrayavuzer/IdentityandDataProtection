namespace IdentityandDataProtection.Services
{
    public interface IUserService
    {
        Task<ServiceMessage> AddUser();
    }
}
