#nullable disable
namespace SportsRosters.Models
{
    public class BaseballRoster
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Number { get; set; }
        public string Position { get; set; }
        public string Bats { get; set; }
        public string Throws { get; set; }
    }
}
