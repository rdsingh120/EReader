using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.Model;
using Amazon.Runtime;
using EReader.Models;

namespace EReader.Services
{
    class DynamoDBOperations
    {
        BasicAWSCredentials credentials;
        AmazonDynamoDBClient client;

        private readonly string? accessKey = Environment.GetEnvironmentVariable("AWS_ACCESS_KEY_ID");
        private readonly string? secretKey = Environment.GetEnvironmentVariable("AWS_SECRET_ACCESS_KEY");

        public DynamoDBOperations()
        {
            credentials = new BasicAWSCredentials(accessKey, secretKey);
            client = new AmazonDynamoDBClient(credentials);
        }

        private async Task<Dictionary<string, AttributeValue>> GetItem(string userName)
        {
            GetItemRequest request = new GetItemRequest
            {
                TableName = "Users",
                Key = new Dictionary<string, AttributeValue>
                {
                    { "UserName", new AttributeValue { S = userName } }
                }
            };

            var response = await client.GetItemAsync(request);

            return response.Item;
        }

        public async Task<User?> GetUser(string userName)
        {
            var user = await GetItem(userName);

            if (user == null || user.Count == 0) return null;

            List<Book> books = new List<Book>();
                       
            foreach (var bookAttribute in user["Books"].L)
            {
                Book book = new Book
                {
                    Name = bookAttribute.M["Name"].S,
                    LastReadPageNumber = int.Parse(bookAttribute.M["LastReadPageNumber"].N),
                    LastReadTime = bookAttribute.M["LastReadTime"].S
                };
                books.Add(book);
            }

            User newUser = new User
            {
                UserName = user["UserName"].S,
                Password = user["Password"].S,
                Books = books
            };


            return newUser;
            

        }
    }
}
