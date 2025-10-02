using Amazon.Runtime;
using Amazon.S3;
using System.IO;

namespace EReader.Services
{
    internal class S3Operations
    {
        private AWSCredentials credentials;
        private AmazonS3Client client;

        private readonly string? accessKey = Environment.GetEnvironmentVariable("AWS_ACCESS_KEY_ID");
        private readonly string? secretKey = Environment.GetEnvironmentVariable("AWS_SECRET_ACCESS_KEY");

        private readonly string bucketName = "mybucketforereaderbooks";
        private readonly string folder = "books/";
        private readonly string extension = ".pdf";

        public S3Operations()
        {
            credentials = new BasicAWSCredentials(accessKey, secretKey);
            client = new AmazonS3Client(credentials, Amazon.RegionEndpoint.USEast1);
        }
        public async Task<Stream> GetBook(string bookName)
        {
            var response = await client.GetObjectAsync(bucketName, folder + bookName + extension);
            MemoryStream memoryStream = new MemoryStream();
            await response.ResponseStream.CopyToAsync(memoryStream);
            memoryStream.Position = 0;
            return memoryStream;
        }
    }
}
