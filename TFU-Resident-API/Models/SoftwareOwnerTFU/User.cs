namespace TFU_Resident_API.Models.SoftwareOwnerTFU
{
    public class User
    {
        public int UserID { get; set; }  
        public string Username { get; set; }  
        public string Password { get; set; }  
        public int RoleID { get; set; } 
        public string Email { get; set; }  
        public string PhoneNumber { get; set; }  
        public bool IsActive { get; set; } 

        public Role Role { get; set; } 
        public ICollection<Investor> Investors { get; set; }  
    }
}
