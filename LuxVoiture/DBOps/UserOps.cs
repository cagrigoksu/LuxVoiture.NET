

using LuxVoiture.Controllers;
using LuxVoiture.Models;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace LuxVoiture.DBOps
{
    public class UserOps
    {
        private MongoClient client = new MongoClient("mongodb://LVDBUser:LuxVoiture_2023@localhost:27017/");

        public int SaveUser(UserModel user) 
        {
            var database = client.GetDatabase("LuxVoitureDB");
            var table = database.GetCollection<UserModel>("users");

            table.InsertOne(user);
            return 200;

        }
    }
}
