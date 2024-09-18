namespace ApiData.Models
{
    public class User
    {
        
        public int Id { get; set; }
        public int TicketNo {  get; set; } 
        public string TcName { get; set; }
        public string Email { get; set; }
        public DateTime DateTime { get; set; }
        public string VehNum { get; set; }
        public int Fare { get; set; }
        public int PenaltyFare { get; set; }



    }
}

 // Add-Migration addmessage 
 // update-database