using System.ComponentModel.DataAnnotations;
using System.Data;

namespace COMP003B.Assignment4.Models
{
    public class VideoGame
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [Required]
        [StringLength(300)]
        public string Description { get; set; }

        [Required]
        [StringLength(50)]
        public string Genre { get; set; }

        public DateTime ReleaseDate { get; set; }
    }
}
