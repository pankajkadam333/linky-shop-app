# Linky Shop

See the overall picture of **implementations on microservices with .NET tools** on real-world **e-commerce microservices** project;

![microservices_remastered](/images/e-commerce%20app.png)

There is a couple of microservices which implemented **e-commerce** modules over **Catalog, Basket, Discount** and **Ordering** microservices with **NoSQL (MongoDB, Redis)** and **Relational databases (PostgreSQL, Sql Server)** with communicating over **RabbitMQ Event Driven Communication** and using **Ocelot API Gateway**.


## Run The Project
You will need the following tools:

* [Visual Studio](https://visualstudio.microsoft.com/downloads/)
* [.Net Core 5 or later](https://dotnet.microsoft.com/download/dotnet-core/5)
* [Docker Desktop](https://www.docker.com/products/docker-desktop)

### Installing
Follow these steps to get your development environment set up: (Before Run Start the Docker Desktop)
1. Clone the repository
2. Once Docker for Windows is installed, go to the **Settings > Advanced option**, from the Docker icon in the system tray, to configure the minimum amount of memory and CPU like so:
* **Memory: 4 GB**
* CPU: 2
3. At the root directory which include **docker-compose.yml** files, run below command:
```csharp
docker-compose -f docker-compose.yml -f docker-compose.override.yml up -d
```
3. Wait for docker compose all microservices. That’s it! (some microservices need extra time to work so please wait if not worked in first shut)

4. You can **launch microservices** as below urls:

* **Catalog API -> http://localhost:8000/swagger/index.html**
* **Basket API -> http://localhost:8001/swagger/index.html**
* **Discount API -> http://localhost:8002/swagger/index.html**
* **Ordering API -> http://localhost:8004/swagger/index.html**
* **Shopping.Aggregator -> http://localhost:8005/swagger/index.html**
* **API Gateway -> http://localhost:8010/Catalog**
* **Rabbit Management Dashboard -> http://localhost:15672**   -- guest/guest
* **Portainer -> http://localhost:9000**   -- admin/admin1234
* **pgAdmin PostgreSQL -> http://localhost:5050**   -- admin@aspnetrun.com/admin1234
* **Elasticsearch -> http://localhost:9200**
* **Kibana -> http://localhost:5601**
* **Web Frontend -> http://localhost:8006**

1. Launch http://localhost:8007 in your browser to view the Web Status. Make sure that every microservices are healthy.
2. Launch http://localhost:8006 in your browser to view the Web UI. You can use Web project in order to **call microservices over API Gateway**. When you **checkout the basket** you can follow **queue record on RabbitMQ dashboard**.


>Note: If you are running this application in macOS then use `docker.for.mac.localhost` as DNS name in `.env` file and the above URLs instead of `localhost`.
