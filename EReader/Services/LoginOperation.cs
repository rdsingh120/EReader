using EReader.Models;

namespace EReader.Services
{
    static class LoginOperation
    {

        public static async Task<bool> CheckCredentails(string username, string password)
        {
            var user = await new DynamoDBOperations().GetUser(username);
            if (user == null) return false;
            if(user.Password != password) return false;
            return true;
        }
    }
}
