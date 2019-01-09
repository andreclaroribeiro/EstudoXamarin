using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace EstudoXamarin.App.Services
{
    public static class UserService
    {
        public static async Task<List<Models.User>> GetAsync()
        {
            using (var client = new HttpClient())
            {
                var json = await client.GetStringAsync("https://reqres.in/api/users");

                var response = JsonConvert.DeserializeObject<Models.ResponseUser>(json);
                var users = response.data;

                users.ForEach(x => x.ImageUrl = "http://upload.wikimedia.org/wikipedia/commons/thumb/f/fc/Papio_anubis_%28Serengeti%2C_2009%29.jpg/200px-Papio_anubis_%28Serengeti%2C_2009%29.jpg");

                return users;
            }
        }
    }
}