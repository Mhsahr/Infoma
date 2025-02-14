using System.ComponentModel.DataAnnotations;

namespace Infoma.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Username {  get; set; }
        public string Firstname {  get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }    
    }
}
