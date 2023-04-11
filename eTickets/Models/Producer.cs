using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Producer
    {
        [Key]
        public int Id{ get; set; }
        public string ProfilePictureURL { get; set; }
        public string fullName { get; set; }
        public string Bio { get; set; }

        //RELATIO0NSHIPS
        public List<Movie> Movies { get; set; }
    }

    

}
