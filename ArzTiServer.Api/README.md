# ArzTiServer - ASP.NET Core 5.0 Server

Kommunikation des Webservers mit den jeweiligen Rechenzentren
V.2021-05-20













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
cd src/ArzTiServer
docker build -t arztiserver .
docker run -p 5000:8080 arztiserver
```
