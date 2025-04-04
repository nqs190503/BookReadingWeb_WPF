using API.DTO.Response;
using API.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages.Shared
{
    public class HeaderModel : PageModel
    {
        private readonly PRN221_Project_1Context context;

        private readonly ApiService.ApiService apiService;

        public HeaderModel(PRN221_Project_1Context context, ApiService.ApiService apiService)
        {
            this.context = context;
            this.apiService = apiService;
        }
        public List<CategoryResponse> Categories { get; set; }  = new List<CategoryResponse>();
        public async void OnGet()
        {
            Categories = await apiService.GetAllCategoryAsync();
        }
    }
}
