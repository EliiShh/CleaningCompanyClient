using CleaningCompanyClient.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;

namespace CleaningCompanyClient.Controllers
{
    public class MissionController : Controller
    {
        private readonly HttpClient _httpClient;
        private readonly string urlAPI = "http://localhost:5147/missions";
        private readonly GeneralViewModel generalViewModel;
        public MissionController(HttpClient httpClient, GeneralViewModel _generalViewModel)
        {
            _httpClient = httpClient;
            generalViewModel = _generalViewModel;
        }
        public async Task<IActionResult> ShouAllMissions()
        {
            var respons = await _httpClient.GetAsync(urlAPI);
            respons.EnsureSuccessStatusCode();
            List<MissionModel> Missions = await respons.Content.ReadFromJsonAsync<List<MissionModel>>();
            return View(Missions);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
