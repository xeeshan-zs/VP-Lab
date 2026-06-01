using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureHub.Mvc.Controllers
{
    public class FurnitureController : Controller
    {
        private readonly HttpClient _httpClient;
        private const string ApiUrl = "http://localhost:5100/api/furniture";

        public FurnitureController()
        {
            _httpClient = new HttpClient();
        }

        // GET: Furniture (Grid list view)
        public async Task<IActionResult> Index()
        {
            try
            {
                var response = await _httpClient.GetStringAsync(ApiUrl);
                
                // LINQ to JSON: Parse the raw JSON array
                JArray items = JArray.Parse(response);
                
                return View(items);
            }
            catch (Exception ex)
            {
                ViewBag.Error = $"Could not connect to FurnitureHub Web API at {ApiUrl}. Details: {ex.Message}";
                return View(new JArray());
            }
        }

        // GET: Furniture/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            try
            {
                var response = await _httpClient.GetStringAsync($"{ApiUrl}/{id}");
                
                // LINQ to JSON: Parse the raw JSON object
                JObject item = JObject.Parse(response);
                
                return View(item);
            }
            catch (Exception ex)
            {
                TempData["Error"] = $"Error loading furniture details: {ex.Message}";
                return RedirectToAction(nameof(Index));
            }
        }

        // POST: Furniture/Edit/5
        [HttpPost]
        public async Task<IActionResult> Edit(int id, int price, int stockQuantity, string name, string category)
        {
            try
            {
                // LINQ to JSON: Programmatically construct the updated JSON payload
                JObject jsonObject = new JObject
                {
                    ["id"] = id,
                    ["name"] = name,
                    ["category"] = category,
                    ["price"] = price,
                    ["stockQuantity"] = stockQuantity
                };

                var content = new StringContent(jsonObject.ToString(), Encoding.UTF8, "application/json");
                var response = await _httpClient.PutAsync($"{ApiUrl}/{id}", content);

                if (response.IsSuccessStatusCode)
                {
                    TempData["Success"] = "Furniture item updated successfully in the Web API database!";
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    ViewBag.Error = $"API returned error code: {response.StatusCode}";
                    return View(jsonObject);
                }
            }
            catch (Exception ex)
            {
                ViewBag.Error = $"Error saving item changes: {ex.Message}";
                
                // Fallback JObject
                JObject fallbackObj = new JObject
                {
                    ["id"] = id,
                    ["name"] = name,
                    ["category"] = category,
                    ["price"] = price,
                    ["stockQuantity"] = stockQuantity
                };
                return View(fallbackObj);
            }
        }
    }
}
