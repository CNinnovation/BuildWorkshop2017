# Docker Lab

## Preparation

1. Install Docker [Docker](https://www.docker.com)
2. Test the first docker image:

> docker run hello-world

## Run ASP.NET Core with docker command-line

1. Start a ASP.NET Core image
2. Create a ASP.NET Core Web application
3. Access this Web application from the browser

> docker run -p 8000:80 -e "ASPNETCORE_URLS=http://+.80" -it --rm microsoft/dotnet

> dotnet new mvc -o mvc --framework netcoreapp1.1

> dotnet restore

> dotnet run


## Run Docker from Visual Studio

1. Create an ASP.NET Core Web application using Visual Studio
2. Add Docker support
3. Run the debug version using the Debugger

4. Run the release version to create a docker image
5. Start the docker image from the command line

Helpful commands:

> docker images

> docker run

> docker ps

