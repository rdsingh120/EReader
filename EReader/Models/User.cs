namespace EReader.Models
{
    class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public List<Book> Books { get; set; }
    }
}
