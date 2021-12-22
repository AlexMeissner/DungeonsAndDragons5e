namespace RestAPI.Payload
{
    public class UserCampaignMappingPayload
    {
        public long UserID { get; set; }
        public long CampaignID { get; set; }
        public bool IsGameMaster { get; set; }
    }
}