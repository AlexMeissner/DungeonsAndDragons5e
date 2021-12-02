using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestAPI.DatabaseSchema
{
    public class UserCampaignMapping
    {
        [Key]
        public long ID { get; set; }
        [ForeignKey("User")]
        public long UserID { get; set; }
        [ForeignKey("Campaign")]
        public long CampaignID { get; set; }
        public bool IsGameMaster { get; set; }
    }
}