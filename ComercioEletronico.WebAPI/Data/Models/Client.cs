namespace ComercioEletronico.WebAPI.Data.Models
{
    public class Client : ApplicationDbContextEntry
    {
        public string Email { get; set; }
        public string ImageBase64 { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
    }
}
