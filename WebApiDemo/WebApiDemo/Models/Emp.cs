using System.ComponentModel.DataAnnotations;

namespace WebApiDemo.Models
{
    public class Emp
    {
        
        public  int  id { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(255)] 
        public string name { get; set; }
        [Range(1,20000)]
        public int salary { get; set; }
        public string address { get; set; }
        [Range(1,300)]
        public int age { get; set; }
    }
}
