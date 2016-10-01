using System.Data;
using NFluent;
using NUnit.Framework;
using RiderPOC.Repositories;

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

        [TestCase("default", true)]
        [TestCase("should'nt fucking exist", false)]
        public void Should_Be_Able_To_Connect_To_MongoDB(string databaseName, bool expected)
        {
            var repo = new RepositoryBase();
            Check.That(repo.DoHeartBeat(databaseName)).Equals(expected);
        }
    }
}


