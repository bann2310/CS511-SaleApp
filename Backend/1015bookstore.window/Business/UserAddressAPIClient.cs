using _1015bookstore.window.ViewModel;
using _1015bookstore.window.ViewModel.UserAddresses;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace _1015bookstore.window.Business
{
    public class UserAddressAPIClient
    {
        private readonly HttpClient _client;
        public UserAddressAPIClient()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri("https://localhost:7139");
        }

        public async Task<ResponseAPI<List<AddressViewModel>>> GetAddressByUser(string session, Guid user_id)
        {
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", session);

            var response = await _client.GetAsync($"/api/useraddress/{user_id}");

            if (response.IsSuccessStatusCode)
            {
                var body = await response.Content.ReadAsStringAsync();
                var addresses = JsonSerializer.Deserialize<List<AddressViewModel>>(body);
                return new ResponseAPI<List<AddressViewModel>>
                {
                    Status = response.StatusCode == System.Net.HttpStatusCode.OK ? true : false,
                    Message = "Thành công",
                    Data = addresses,
                };
            }
            else
            {
                return new ResponseAPI<List<AddressViewModel>>
                {
                    Status = response.StatusCode == System.Net.HttpStatusCode.OK ? true : false,
                    Message = await response.Content.ReadAsStringAsync(),
                    Data = new List<AddressViewModel>(),
                };
            }
        }

        public async Task<ResponseAPI<JObject>> DeleteAddress(string session, int id)
        {

            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", session);

            var response = await _client.DeleteAsync($"/api/useraddress?iAddress_id={id}");

            return new ResponseAPI<JObject>
            {
                Status = response.StatusCode == System.Net.HttpStatusCode.OK ? true : false,
                Message = await response.Content.ReadAsStringAsync(),
                Data = new Object() as JObject,
            };
        }
    }
}
