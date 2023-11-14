# svar-o-matic

To run this project, the following pre-requisites are needed:
- [Docker](https://www.docker.com/products/docker-desktop/) (or a similar [container runtime](https://podman.io/docs/installation))

> **_NOTE:_** all of the following commands are assumed to be executed from the same path as this readme file.

## To build backend image, run:
```shell
cd src/backend-placeholder
docker build -t svar-o-matic-backend -f backend-placeholder/Dockerfile .
```

## To build frontend image, run:
```shell
cd src/frontend-placeholder
docker build -t svar-o-matic-frontend -f Dockerfile .
```

## To run backend image as a container, run the following command and access it from `http://localhost:1080/WeatherForecast`:
```shell
docker run -d -p 1080:80 svar-o-matic-backend
```

## To run frontend image as a container, run the following and access it from `http://localhost:3000`:
```shell
docker run -d -p 3000:3000 svar-o-matic-frontend
```

## To automatically build everything and run all images, run the following command and access frontend at `http://localhost:3000` and backend at `http://localhost:10080/WeatherForecast`:
```shell
docker compose up -d
```

## To stop all services (ran with docker compose), run:
```shell
docker compose down
```