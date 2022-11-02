using MVCProjects.Helpers;
using MVCProjects.Models;
using MVCProjects.Services.Interfaces;

namespace MVCProjects.Services
{
    public class Class1sService: IClass1sService
    {
        private readonly HttpClient _client;
        public const string BasePath = "/api/Class1s/";

        public Class1sService(HttpClient client)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));
        }

        public async Task<IEnumerable<Class1s>> FindAll()
        {
            var responseGet = await _client.GetAsync(BasePath);

            var response = await responseGet.ReadContentAsync<List<Class1s>>();

            return response;
        }

        public async Task<Class1s> FindOne(int id)
        {
            var request = BasePath + id.ToString();
            var responseGet = await _client.GetAsync(request);

            var response = await responseGet.ReadContentAsync<Class1s>();

            var class1s = new Class1s(response.Id, response.player, response.teams, response.preferdfoot, response.Height, response.weight, response.nationality, response.position, response.salary, response.age);

            return class1s;
        }
    }
}

