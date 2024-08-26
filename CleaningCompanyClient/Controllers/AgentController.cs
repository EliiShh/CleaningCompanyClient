using CleaningCompanyClient.Models;
using Microsoft.AspNetCore.Mvc;

namespace CleaningCompanyClient.Controllers
{
    public class AgentController : Controller
    {
        private readonly HttpClient _httpClient;
        private readonly string urlAPI = "http://localhost:5147/agents";
        private readonly GeneralViewModel generalViewModel;
        public AgentController(HttpClient httpClient, GeneralViewModel _generalViewModel)
        {
            _httpClient = httpClient;
            generalViewModel = _generalViewModel;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> ShouAllAgents()
        {
            var respons = await _httpClient.GetAsync(urlAPI);
            respons.EnsureSuccessStatusCode();
            List<AgentModel> Agents = await respons.Content.ReadFromJsonAsync<List<AgentModel>>();
            return View(Agents);
        }

        //public async Task<IActionResult> ShouAll()
        //{
        //    return View(generalViewModel.ShouAllmissions());
        //}
    }
}
