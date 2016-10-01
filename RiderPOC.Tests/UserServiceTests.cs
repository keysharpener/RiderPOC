using System;
using NFluent;
using NUnit.Framework;

namespace RiderPOC.Tests
{
    public class UserServiceTests
    {
        [Test]
        public void Should_Return_Standard_Value_When_Requested()
        {
            var userSerice = new UserService();
            var returnValue = userSerice.GetUserById(2);
            Check.That(returnValue.FirstName).Equals("Robin");
        }
    }
}


