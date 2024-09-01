using HealthNewsWebApplication.Models;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HealthNewsWebApplication.Services
{
    public class NewsService
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseUrl = "https://newsapi.org/v2/";
        private readonly string _apiKey = "9e1c3a6a5092415d90a47331641a0525";

        public NewsService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            // Set the User-Agent header
            _httpClient.DefaultRequestHeaders.Add("User-Agent", "HealthNewsWebApp/1.0");
        }

        public async Task<List<Article>> GetHealthNewsAsync(string category = "Health")
        {
            var requestUri = $"{_baseUrl}everything?q={category}&apiKey={_apiKey}";
            var response = await _httpClient.GetAsync(requestUri);

            if (response.IsSuccessStatusCode)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                var newsResponse = JsonConvert.DeserializeObject<NewsApiResponse>(jsonString);
                return newsResponse?.Articles ?? new List<Article>();
            }
            else
            {
                Console.WriteLine($"Error: {response.StatusCode}, Content: {await response.Content.ReadAsStringAsync()}");
                return new List<Article>();
            }
        }

        
    }


}
