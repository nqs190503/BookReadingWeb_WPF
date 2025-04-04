using API.DTO.Response;

namespace WebApp.ApiService
{
    public class ApiService
    {
        private readonly HttpClient _httpClient;

        public ApiService(IHttpClientFactory httpClient)
        {
            _httpClient = httpClient.CreateClient("ApiServices");
        }

        public async Task<List<CategoryResponse>> GetAllCategoryAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<CategoryResponse>>("books/categories"); // Gọi API GET /api/books
        }
    }
}
