using System.ComponentModel.DataAnnotations;

namespace TestApplication3.Models
{
    public class Values
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}