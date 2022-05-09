namespace CondSolutions.Authorization.Models
{
    public class RefreshToken
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }
        public string TokenHash { get; set; }
        public string TokenSalt { get; set; }
        public DateTime Ts { get; set; }
        public DateTime ExpiryDate { get; set; }
        public User User { get; set; }
    }
}
