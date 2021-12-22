namespace RestAPI.Models
{
    public class UserCampaignMappingModel
    {
        public long ID { get; set; }
        public long UserID { get; set; }
        public long CampaignID { get; set; }
        public bool IsGameMaster { get; set; }
    }
}