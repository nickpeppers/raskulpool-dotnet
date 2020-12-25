using NUnit.Framework;
using RaskulPool.Services;
using System.Linq;
using System.Threading.Tasks;

namespace RaskulPool.NUnit
{
    public class RaskulApiServiceTests
    {
        IRaskulApiService _raskulApiService = new RaskulApiService();

        [Test]
        public async Task GetStatsTest()
        {
            var stats = await _raskulApiService.GetStats();

            Assert.IsNotNull(stats);
            Assert.AreEqual("beam", stats.Pools.Beam.Name);
            Assert.AreEqual("BEAM", stats.Pools.Beam.Symbol);
        }

        [Test]
        public async Task GetBlocksTest()
        {
            var blocks = await _raskulApiService.GetBlocks();

            Assert.IsNotNull(blocks);
            Assert.IsTrue(blocks.Count > 0);
        }

        [Test]
        public async Task GetStatusTest()
        {
            var status = await _raskulApiService.GetStatus();

            Assert.IsNotNull(status);
            Assert.IsTrue(status.NodeHeight > 0);
            Assert.IsTrue(status.LastMinedHeight > 0);
        }

        [Test]
        public async Task GetPoolStatsTest()
        {
            var poolStats = await _raskulApiService.GetPoolStats();
            Assert.IsNotNull(poolStats);
            Assert.IsTrue(poolStats.Count > 0);
        }

        [Test]
        public async Task GetPaymentsTest()
        {
            var payments = await _raskulApiService.GetPayments();

            Assert.IsNotNull(payments);
            Assert.AreEqual("beam", payments.FirstOrDefault().Name);
        }

        [Test]
        public async Task GetWorkerStatsTest()
        {
            var minerAddress = "14e8f15c032cc6a2c402e500a68b6ae0b3be6d92f6232930dc974da5c251be9166";
            var stats = await _raskulApiService.GetWorkerStats(minerAddress);

            Assert.IsNotNull(stats);
            Assert.AreEqual(minerAddress, stats.Miner);
        }
    }
}