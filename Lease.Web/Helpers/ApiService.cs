using Lease.Common.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Lease.Web.Helpers
{
    public class ApiService : IApiService
    {
        private readonly HttpClient _httpClient;
        public ApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<State>> GetStates()
        {
            return await JsonSerializer.DeserializeAsync<IEnumerable<State>>
                (await _httpClient.GetStreamAsync("api/state"),
                new JsonSerializerOptions() { PropertyNameCaseInsensitive = true, PropertyNamingPolicy = null });
        }

        public async Task<IEnumerable<Term>> GetTerms()
        {
            return await JsonSerializer.DeserializeAsync<IEnumerable<Term>>
                (await _httpClient.GetStreamAsync("api/term"),
                new JsonSerializerOptions() { PropertyNameCaseInsensitive = true, PropertyNamingPolicy = null });
        }

        public async Task<LeaseItem> AddLease(LeaseItem leaseItem)
        {
            var lease = new StringContent(JsonSerializer.Serialize(leaseItem), Encoding.UTF8, "application/json");
            var addLeaseResponse = await _httpClient.PostAsync("api/lease", lease);

            if(addLeaseResponse.IsSuccessStatusCode)
            {
                return await JsonSerializer.DeserializeAsync<LeaseItem>(await addLeaseResponse.Content.ReadAsStreamAsync());
            }
            return null;
        }
    }

    public interface IApiService
    {
        Task<IEnumerable<State>> GetStates();
        Task<IEnumerable<Term>> GetTerms();
        Task<LeaseItem> AddLease(LeaseItem leaseItem);
    }
}
