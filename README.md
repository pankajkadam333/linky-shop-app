# **Linky Shop 🛍️**

Get an in-depth look at real-world e-commerce microservices project implementations using .NET tools.

🚀 Check out our frontend:

![presentation](images/presentation.gif)

Our e-commerce modules are implemented on Catalog, Basket, Discount, and Ordering microservices, which use NoSQL (MongoDB, Redis) and Relational databases (PostgreSQL, Sql Server) and communicate via RabbitMQ Event Driven Communication. Plus, we use Ocelot API Gateway for seamless integration.

🎥 Here's a quick presentation of our architecture:

![e-commerce app](images/e-commerce%20app.png)

## **Run The Project**

You'll need the following tools:

- **[Visual Studio](https://visualstudio.microsoft.com/downloads/)**
- **[.Net Core 5 or later](https://dotnet.microsoft.com/download/dotnet-core/5)**
- **[Docker Desktop](https://www.docker.com/products/docker-desktop)**

### **Installing**

Follow these simple steps to set up your development environment: (Before running, start Docker Desktop)

1. Clone the repository.
2. Install Docker for Windows and configure the minimum amount of memory and CPU:
    - Memory: 4 GB
    - CPU: 2
3. At the root directory which includes **`docker-compose.yml`** files, run the following command:

```
csharpCopy code
docker-compose -f docker-compose.yml -f docker-compose.override.yml up -d

```

1. Wait for Docker to compose all microservices. And that's it! (Some microservices may take longer to work, so please be patient if they don't work on the first run)
2. You can now launch the microservices from the following URLs:
- Catalog API -> **[http://localhost:8000/swagger/index.html](http://localhost:8000/swagger/index.html)**
- Basket API -> **[http://localhost:8001/swagger/index.html](http://localhost:8001/swagger/index.html)**
- Discount API -> **[http://localhost:8002/swagger/index.html](http://localhost:8002/swagger/index.html)**
- Ordering API -> **[http://localhost:8004/swagger/index.html](http://localhost:8004/swagger/index.html)**
- Shopping.Aggregator -> **[http://localhost:8005/swagger/index.html](http://localhost:8005/swagger/index.html)**
- API Gateway -> **[http://localhost:8010/Catalog](http://localhost:8010/Catalog)**
- Rabbit Management Dashboard -> **[http://localhost:15672](http://localhost:15672/)** (guest/guest)
- Portainer -> **[http://localhost:9000](http://localhost:9000/)** (admin/admin1234)
- pgAdmin PostgreSQL -> **[http://localhost:5050](http://localhost:5050/)** (**[admin@mnia.com](mailto:admin@mnia.com)**/admin1234)
- Elasticsearch -> **[http://localhost:9200](http://localhost:9200/)**
- Kibana -> **[http://localhost:5601](http://localhost:5601/)**
- Web Frontend -> **[http://localhost:8006](http://localhost:8006/)**
1. Launch **[http://localhost:8007](http://localhost:8007/)** in your browser to view the Web Status. Ensure that every microservice is healthy.
2. Launch **[http://localhost:8006](http://localhost:8006/)** in your browser to view the Web UI. You can use the Web project to call microservices over API Gateway. When you checkout the basket, you can follow the queue record on the RabbitMQ dashboard.

> Note: If you're running this application on macOS, use docker.for.mac.localhost as the DNS name in the .env file and use the above URLs instead of localhost.
>
