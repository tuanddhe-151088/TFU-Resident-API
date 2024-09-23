using System.ComponentModel.DataAnnotations;

namespace TFU_Resident_API.Models.SoftwareOwnerTFU
{
    public class Role
    {
        [Key]
        public int RoleID { get; set; }  
        public string RoleName { get; set; } 

        public ICollection<User> Users { get; set; }
    }
}
