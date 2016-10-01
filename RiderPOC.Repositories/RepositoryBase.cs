using System;
using MongoDB.Driver;

namespace RiderPOC.Repositories
{
    public class RepositoryBase
    {
        public bool DoHeartBeat(string databaseName)
        {
            var client = new MongoClient();
            var database = client.GetDatabase(databaseName);
            return database != null;
        }
    }
}


