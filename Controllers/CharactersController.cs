using Newtonsoft.Json;
using RYMApi.Models;
using System.Net.Http;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;

namespace RYMApi.Controllers
{
    public class CharactersController
    {
       
        private HttpClient client;

        public CharactersController()
        {
            client = new HttpClient();

            // Agregar encabezado User-Agent (si es necesario)
            client.DefaultRequestHeaders.Add("User-Agent", "MyApp/1.0");
        }
         
        public async Task<Characters?> GetAllCharacters()   
        {
            try
            {
                Characters characters = new Characters();
                HttpResponseMessage response = await
                client.GetAsync("https://rickandmortyapi.com/api/character");

                response.EnsureSuccessStatusCode();

                string responseJson = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<Characters>(responseJson);

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
        }
    }
}
