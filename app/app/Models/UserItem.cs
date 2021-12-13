namespace app.Models
{
    public class UserItem
    {
        public long Id { get; set; }
        public string? username { get; set; }
        public string? email { get; set; }
        public bool subscription { get; set; }
        public string? password { get; set; }
    }
}
