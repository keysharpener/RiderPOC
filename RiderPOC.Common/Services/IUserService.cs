using RiderPOC.Common.ObjectModel;

namespace RiderPOC.Common.Services
{
    public interface IUserService
    {
        IUser GetUserById(int id);
    }
}