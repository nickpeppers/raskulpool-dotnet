using Newtonsoft.Json;
using RaskulPool.Models;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace RaskulPool.Services
{
    public interface IRaskulApiService
    {
        Task<List<BlockInfo>> GetBlocks();
        Task<List<Payments>> GetPayments();
        Task<List<PoolStatsInfo>> GetPoolStats();
        Task<Stats> GetStats();
        Task<Status> GetStatus();
        Task<WorkerStats> GetWorkerStats(string address);
    }

    public class RaskulApiService : IRaskulApiService
    {
        static readonly HttpClient _httpClient = new HttpClient();
        static readonly JsonSerializer _serializer = new JsonSerializer();

        public async Task<Stats> GetStats()
        {
            return await SerializeJson<Stats>(Constants.StatsUrl);
        }

        public async Task<List<BlockInfo>> GetBlocks()
        {
            return await SerializeJson<List<BlockInfo>>(Constants.BlocksUrl);
        }

        public async Task<Status> GetStatus()
        {
            return await SerializeJson<Status>(Constants.StatusUrl);
        }

        public async Task<List<PoolStatsInfo>> GetPoolStats()
        {
            return await SerializeJson<List<PoolStatsInfo>>(Constants.PoolStatsUrl);
        }

        public async Task<List<Payments>> GetPayments()
        {
            return await SerializeJson<List<Payments>>(Constants.PaymentsUrl);
        }

        public async Task<WorkerStats> GetWorkerStats(string address)
        {
            return await SerializeJson<WorkerStats>(Constants.WorkerStatsUrl + address);
        }

        async Task<T> SerializeJson<T>(string url)
        {
            var response = await _httpClient.GetAsync(url);
            using (response)
            {
                response.EnsureSuccessStatusCode();

                using (var stream = await response.Content.ReadAsStreamAsync())
                using (var reader = new StreamReader(stream))
                using (var json = new JsonTextReader(reader))
                {
                    return _serializer.Deserialize<T>(json);
                }
            }
        }
    }
}