namespace TFU_Resident_API.Models.SoftwareOwnerTFU
{
    public class Investor
    {
        public int InvestorID { get; set; }  
        public int UserID { get; set; }  
        public string CompanyName { get; set; } 
        public DateTime StartDate { get; set; }  

        // Navigation properties
        public User User { get; set; }  
        public ICollection<Payment> Payments { get; set; }  
    }
}
