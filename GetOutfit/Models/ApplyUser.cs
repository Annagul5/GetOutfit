using System.ComponentModel.DataAnnotations;

namespace GetOutfit.Models
{
    /// <summary>
    /// bizle iletisime gecmek icin
    /// </summary>
    public class ApplyUser
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
      
        public string Subject { get; set; }
        [Required]
        public string Message { get; set; }
    }
}
