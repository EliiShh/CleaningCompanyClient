namespace CleaningCompanyClient.Models
{
    public class AgentModel
    {
        public AgentModel() { IsActive = false; }
        public int Id { get; set; }
        public string Nickname { get; set; }
        public int? locX { get; set; }
        public int? locY { get; set; }
        //public string? photo_url { get; set; }
        public string? photoUrl { get; set; }

        public bool IsActive { get; set; }
    }
}
