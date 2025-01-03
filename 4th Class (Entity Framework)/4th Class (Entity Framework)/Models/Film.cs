using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _4th_Class__Entity_Framework_.Models
{
    public class Film
    {
        [Key]
        public int ID { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Name { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public string Description { get; set; }

        [Column(TypeName = "int")]
        public int Rating { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}