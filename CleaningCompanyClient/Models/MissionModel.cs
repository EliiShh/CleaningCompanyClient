using CleaningCompany.Utils;

namespace CleaningCompanyClient.Models
{
    public class MissionModel
    {
        public MissionModel() { Status = MissionStatus.proposal; }
        public int Id { get; set; }
        public int AgentId { get; set; }
        public int TargetId { get; set; }
        public string? TimeLeft { get; set; }
        public string? ExecutionTime { get; set; }
        public MissionStatus Status { get; set; }
    }
}
