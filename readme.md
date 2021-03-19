# OpenTelemetry With ASP.NET Core

## Prerequisites

- Docker for Desktop
- .NET 5

## Getting Started

1. Start a Jaeger "all-in-one" docker container. Use the following command.

```
docker run -d --name jaeger \
  -e COLLECTOR_ZIPKIN_HOST_PORT=:9411 \
  -p 5775:5775/udp \
  -p 6831:6831/udp \
  -p 6832:6832/udp \
  -p 5778:5778 \
  -p 16686:16686 \
  -p 14268:14268 \
  -p 14250:14250 \
  -p 9411:9411 \
  jaegertracing/all-in-one:latest
aaff1f5b17ab15d49153281ba692618a9f22a4ef483a4ec8c8ea0fa93f1b97d8
```

If you have any other containers listening on these ports, its a good time to shut them down.

2. Run the ASP.NET Core web application at `https://localhost:5001` or `http://localhost:5000`

3. Open the Jaeger UI at `http://localhost:16686/search` and select `API` from the service dropdown and start exploring the traces.

