namespace CleaningCompanyClient.Models
{
    public class TargetModel
    {
        public TargetModel() { IsLife = true; }
        public int Id { get; set; }
        public string name { get; set; }
        public string? position { get; set; }
        public int? locX { get; set; }
        public int? locY { get; set; }
        public string? photoUrl { get; set; }
        public bool IsLife { get; set; }
    }
}
