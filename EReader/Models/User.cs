namespace EReader.Models
{
    class User
    {
        public String Email { get; set; }
        public string Password { get; set; }
        public List<Book> Books { get; set; }
    }
}
