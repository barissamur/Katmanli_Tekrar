using ApplicationCore.Entities;
using Web.Interfaces;
using Web.Models;

namespace Web.Services
{
    public class YazarlarViewModelService : IYazarlarViewModelService
    {
        public async Task<YazarlarViewModel> GetYazarlarVm()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:7042/"); // Uri = api adresi
                var response = await client.GetAsync("api/YazarCrud");
                var result = await response.Content.ReadFromJsonAsync<List<Yazar>>(); // response'u JSON'dan okuyup dönecek türünü yazıyoruz

                var yazarlarVm = new YazarlarViewModel()
                {
                    Yazarlar = result!
                };

                return yazarlarVm; // gelen sonucu View'a gönderdik
            }
        }
    }
}
