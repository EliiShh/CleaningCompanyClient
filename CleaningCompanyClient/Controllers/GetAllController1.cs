using CleaningCompanyClient.Models;
using Microsoft.AspNetCore.Mvc;

namespace CleaningCompanyClient.Controllers
{
    public class GetAllController1 : Controller
    {
        private readonly HttpClient _httpClient;
        private readonly string urlAPI = "http://localhost:5147/missionsparsonal";
        private readonly GeneralViewModel generalViewModel;
        public GetAllController1(HttpClient httpClient, GeneralViewModel _generalViewModel)
        {
            _httpClient = httpClient;
            generalViewModel = _generalViewModel;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> ShouAllMissionsPersonel()
        {
            var respons = await _httpClient.GetAsync(urlAPI);
            respons.EnsureSuccessStatusCode();
            List<getAllModel> MissionsParsonel = await respons.Content.ReadFromJsonAsync<List<getAllModel>>();
            return View(MissionsParsonel);
        }

        public async Task<IActionResult> Edit(int id)
        {
            HttpContent httpContent = new StringContent("assigned");
            var ooo = await _httpClient.PutAsync($"http://localhost:5147/missions/{id.ToString()}", null);
            return RedirectToAction("ShouAllMissionsPersonel");
        }

        public async Task<IActionResult> SouwAllMenegmant()
        {
            var respons = await _httpClient.GetAsync("http://localhost:5147/general");
            respons.EnsureSuccessStatusCode();
            GeneralViewModel res = await respons.Content.ReadFromJsonAsync<GeneralViewModel>();
            return View(res);
        }
    }
}
