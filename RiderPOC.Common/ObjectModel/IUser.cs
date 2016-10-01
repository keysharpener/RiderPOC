namespace RiderPOC.Common.ObjectModel
{
    public interface IUser:IObjectBase
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string Email { get; set; }
        string Adress { get; set; }
        int ZipCode { get; set; }
        string City { get; set; }
    }
}