using Microsoft.AspNetCore.Mvc;

namespace CleaningCompanyClient.Models
{
    public class GeneralViewModel
    {
        private readonly HttpClient _httpClient;
        private readonly string urlAPI = "http://localhost:5147/missions";
        public GeneralViewModel(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        //public List<MissionModel> vcvc { get { return ShouAllAgents(); }}

        public async Task<List<MissionModel>> ShouAllmissions()
        {
            var respons = await _httpClient.GetAsync(urlAPI);
            respons.EnsureSuccessStatusCode();
            List<MissionModel> missions = await respons.Content.ReadFromJsonAsync<List<MissionModel>>();
            return missions;
        }
    }
}
