# IO.Swagger - ASP.NET Core 2.0 Server

This is the backend for a solution that allows employees of Miles AS to efficiently match incoming project requests with existing consultant expertise.  Some useful links: - [The Svar-o-Matic repository](https://github.com/miles-no/svar-o-matic)

## Run

Linux/OS X:

```
sh build.sh
```

Windows:

```
build.bat
```

## Run in Docker

```
cd src/IO.Swagger
docker build -t io.swagger .
docker run -p 5000:5000 io.swagger
```
