# raskulpool-dotnet
.NET implementation for Raskul BEAM Pool API https://pool.raskul.com/api

## How to use ##

```
IRaskulApiService _apiService = new RaskulApiService();

var stats = await _apiService.GetStats();
var blocks = await _apiService.GetBlocks();
var status = await _apiService.GetStatus();
var poolStats = await _apiService.GetPoolStats();
var payments = await _apiService.GetPayments();
var workerStats = await _apiService.GetWorkerStats(minerAddress);
```

Note: all api calls should be surrounded in a try catch
