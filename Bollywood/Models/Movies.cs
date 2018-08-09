using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static Bollywood.Enums.BollywoodEnums;

namespace Bollywood.Models
{
    [Table("Movie")]
    public class Movie
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MovieId { get; set; }

        [Required]
        [StringLength(100,ErrorMessage ="Movie name must not be more than 100 chaaracters", MinimumLength = 1)]
        public string MovieName { get; set; }

        [Required]
        public int ReleaseYear { get; set; }

        [Required]
        [StringLength(25, ErrorMessage = "Verdict must not be more than 25 chaaracters", MinimumLength = 1)]
        public Verdict Verdict { get; set; }

        [Required]
        public decimal BoxOffice { get; set; }

        [Required]
        public string ImgSrc { get; set; }

        [Required]
        public Genre Genre { get; set; }

        [Required]
        [StringLength(5000, ErrorMessage = "Description must not be more than 5000 chaaracters", MinimumLength = 1)]
        public string Description { get; set; }
    }


}
