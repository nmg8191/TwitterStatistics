# TwitterStatistics

With Tweet Statistics Database as my Domain and Domain Models exposed to the Background Service reading from Twitter API.

In Memory Database that can be set up based on sharding to support higher volume.

Task Parallel to spawn multiple threads to read from Twitter API

Vault (Sidecar pattern) to manage Bearer tokens.

Statistics API reads from database (and used redis/sharding) to manage performance.

Purge process to keep size of database manageable.

Would create more C# Projects for the solution (Infrastructure, Application, Services, Models) and Unit Testing and Integration Testing

