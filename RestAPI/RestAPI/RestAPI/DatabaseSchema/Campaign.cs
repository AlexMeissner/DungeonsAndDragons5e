using System.ComponentModel.DataAnnotations;

namespace RestAPI.DatabaseSchema
{
    public class Campaign
    {
        [Key]
        public long ID { get; set; }
        public string Name { get; set; }
        public string PreviewImage { get; set; }
    }
}