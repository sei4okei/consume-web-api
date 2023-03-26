using consume_web_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Text.Json;

namespace consume_web_api
{
    internal class HTTPClient
    {
        public async Task<Users> GetUserId(int id)
        {
            Users users = null;

            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync("https://localhost:7171/api/users/" + id.ToString());
                response.EnsureSuccessStatusCode();
                if (response.IsSuccessStatusCode)
                {
                    users = await response.Content.ReadAsAsync<Users>();
                }

                return users;
            }
        }

        public async Task<Users> EditUserId(Users user)
        {

            using (HttpClient client = new HttpClient())
            {
                var response = await client.PutAsJsonAsync("https://localhost:7171/api/users/" + user.Id, user);
                response.EnsureSuccessStatusCode();

                user = await response.Content.ReadAsAsync<Users>();
                return user;
            }
        }

        public async Task<Uri> AddUserID(Users user)
        {

            using (HttpClient client = new HttpClient())
            {
                var response = await client.PostAsJsonAsync("https://localhost:7171/api/users/", user);
                response.EnsureSuccessStatusCode();

                return response.Headers.Location;
            }
        }

        public async Task<HttpStatusCode> DeleteUserId(int id)
        {

            using (HttpClient client = new HttpClient())
            {
                var response = await client.DeleteAsync("https://localhost:7171/api/users/" + id);

                return response.StatusCode;
            }
        }
    }
}
