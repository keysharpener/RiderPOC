namespace RiderPOC
{
    public class User : ObjectBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class ObjectBase
    {
        public int Id { get; set; }
    }
}