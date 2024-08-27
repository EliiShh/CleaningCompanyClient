using CleaningCompanyClient.Models;
using Microsoft.AspNetCore.Mvc;

namespace CleaningCompanyClient.Controllers
{
    public class TargetController : Controller
    {
        private readonly HttpClient _httpClient;
        private readonly string urlAPI = "http://localhost:5147/targets";
        public TargetController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> ShouAllTargets()
        {
            var respons = await _httpClient.GetAsync(urlAPI);
            respons.EnsureSuccessStatusCode();
            List<TargetModel> Targets = await respons.Content.ReadFromJsonAsync<List<TargetModel>>();
            return View(Targets);
        }

    }
}
