using CleaningCompany.Utils;

namespace CleaningCompanyClient.Models
{
    public class getAllModel
    {

        public int? AgentId { get; set; }
        public string? AgentNickname { get; set; }
        public int? AgentlocX { get; set; }
        public int? AgentlocY { get; set; }
        public string? AgentphotoUrl { get; set; }
        public int? MissionId { get; set; }
        public string? MissionTimeLeft { get; set; }
        public string? MissionExecutionTime { get; set; }
        public int? TargetId { get; set; }
        public string? Targetname { get; set; }
        public string? Targetposition { get; set; }
        public int? TargetlocX { get; set; }
        public int? TargetlocY { get; set; }
        public string? TargetphotoUrl { get; set; }
    }
}
