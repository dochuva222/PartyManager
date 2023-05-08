using Newtonsoft.Json;
using PartyManagerLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyManagerLib.Services
{
    public static class NetManager
    {
        private static string URL = "https://rfr13702.bomj.cfd/Diplom/PHP/db.php";

        private static HttpClient HttpClient = new HttpClient();

        //public static async Task<HttpResponseMessage> Post<T>(string controller, T data)
        //{
        //    var jsonData = JsonConvert.SerializeObject(data);
        //    var response = await HttpClient.PostAsync(URL + controller, new StringContent(jsonData, Encoding.UTF8, "application/json"));
        //    return response;
        //}

        public async static Task<List<Employee>> GetEmployees()
        {
            var formData = new KeyValuePair<string, string>[]
            {
                new KeyValuePair<string, string>("Method", "GetEmployees")
            };
            var response = await Post(formData);
            return JsonConvert.DeserializeObject<List<Employee>>(await response.Content.ReadAsStringAsync());
        }

        public async static Task<Employee> GetEmployee(int userId)
        {
            var formData = new KeyValuePair<string, string>[]
            {
                new KeyValuePair<string, string>("Method", "GetEmployee"),
                new KeyValuePair<string, string>(nameof(userId), userId.ToString())
            };
            var response = await Post(formData);
            return JsonConvert.DeserializeObject<Employee>(await response.Content.ReadAsStringAsync());
        }

        public async static Task<Employee> Login(string login, string password)
        {
            var formData = new KeyValuePair<string, string>[]
            {
                new KeyValuePair<string, string>("Method", "Login"),
                new KeyValuePair<string, string>(nameof(login), login),
                new KeyValuePair<string, string>(nameof(password), password),
            };
            var response = await Post(formData);
            var v = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<Employee>>(v).FirstOrDefault();
        }

        public async static Task<List<Role>> GetRoles()
        {
            var formData = new KeyValuePair<string, string>[]
            {
                new KeyValuePair<string, string>("Method", "GetRoles")

            };
            var response = await Post(formData);
            return JsonConvert.DeserializeObject<List<Role>>(await response.Content.ReadAsStringAsync());
        }

        private static async Task<HttpResponseMessage> Post(KeyValuePair<string, string>[] formData)
        {
            var formContent = new FormUrlEncodedContent(formData);
            var response = await HttpClient.PostAsync(URL, formContent);
            return response;
        }
    }
}
