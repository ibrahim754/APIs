
 
namespace MovieApi.Models
{
    public class Genre
    {
        // all props are required by default
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
    }
}
