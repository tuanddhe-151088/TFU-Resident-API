namespace TFU_Resident_API.Models.SoftwareOwnerTFU
{
    public class Payment
    {
        public int PaymentID { get; set; }  
        public int InvestorID { get; set; }  
        public DateTime PaymentDate { get; set; }  
        public decimal Amount { get; set; }  
        public string PaymentMethod { get; set; }  
        public string PaymentStatus { get; set; }  

       
        public Investor Investor { get; set; }  
    }
}
