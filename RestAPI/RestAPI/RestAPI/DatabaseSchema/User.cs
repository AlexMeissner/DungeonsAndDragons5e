using System.ComponentModel.DataAnnotations;

namespace RestAPI.DatabaseSchema
{
    public class User
    {
        [Key]
        public long ID { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
    }
}