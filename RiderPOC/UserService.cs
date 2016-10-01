namespace RiderPOC
{
    public class UserService
    {
        public User GetUserById(int id)
        {
            return new User {FirstName = "Robin", LastName = "Francillon", Id = 10};
        }
    }
}