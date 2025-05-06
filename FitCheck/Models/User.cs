public class User
{
    public int UserId { get; set; }
    public string Username { get; set; }
    public string PasswordHash { get; set; }
    public string Role { get; set; } // "Admin" or "Staff"
    public bool IsActive { get; set; }
}

