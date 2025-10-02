using EReader.Models;

namespace EReader.Services
{
    static class LoginOperation
    {

        public static async Task<User?> CheckCredentails(string username, string password)
        {
            var user = await new DynamoDBOperations().GetUser(username);
            if (user == null) return null;
            if(user.Password != password) return null;
            return user;
        }
    }
}
