using RiderPOC.Common.ObjectModel;
using RiderPOC.Common.Services;

namespace RiderPOC
{
    public class UserService : IUserService
    {
        public IUser GetUserById(int id)
        {
            return new User {FirstName = "Robin", LastName = "Francillon", Id = 10};
        }
    }
}