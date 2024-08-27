using CleaningCompany.Utils;

namespace CleaningCompanyClient.Models
{
    public class GeneralViewModel
    {
        public string angetsCount { get; set; }
        public string angetsToActivCount { get; set; }

        public string targetsCount { get; set; }

        public string targetsToFinishCount { get; set; }

        public string missionCount { get; set; }

        public string missionToActivCount { get; set; }

        public string RelationAgentsTargets { get; set; }

        public string RelationAgentsTargetsInActiv { get; set; }
    }
}
