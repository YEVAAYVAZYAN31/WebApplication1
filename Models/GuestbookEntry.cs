//We write database on the Model folder 
//Through NuGet we connect Entity to our project by downloading Microsoft.EntityFrameworkCore.SqlServer


namespace WebApplication1.Models
{
    public class GuestbookEntry
    {
        public int Id { get; set; }
        public string Name { get; set; } //Here clients will write their name
        public string Message { get; set; } //Here they will leave a message
        public DateTime DateAdded { get; set; } //This will save the date time of when the user did the post 
    }
}
