namespace ChatAppAPI.Entities
{
    public class TblUser
    {
        public int Id { get; set; } 
        public string LoginId { get; set; } 
        public string UserName { get; set; }

        public string Password { get; set; }
    }
}
