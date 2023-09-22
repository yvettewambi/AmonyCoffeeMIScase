# Instructions

Languages used: C#

Web framework: .NET 7

To run this project, do the following:

Download .NET 7 SDK here - https://dotnet.microsoft.com/en-us/download/dotnet/7.0

Run the installer and in the terminal run: 

```dotnet --version```

Output should show the dotnet version installed



Within VS code terminal, run the following commands:

Build the app:

```dotnet build```

Install certs required for the app to run:

```dotnet dev-certs https --trust```

NB: After running this command, reopen your browser


Run the app: 

```dotnet run```

Access the application on this URL: https://localhost:7208/

**How to build and run the application using Docker**

1. Clone/Fork the Repo.

2. Download and install the latest version of [Visual Studio] (https://visualstudio.microsoft.com/)

3. Install the required Visual Studio workloads for the application.

4. Download and Install [Docker Desktop] (https://docs.docker.com/desktop/install/windows-install/) 

5. Build the Container image in Visual Studio by right clicking on the main solution file (AmonyCoffeeMIS) and then select Build/Rebuild solution.

6. In Visual Studio select the required configuration (Debug) in this case during development and then click the run button to start the Docker. This will start the Docker Container on a random port.

Optional Configuration


* To start the container(s)
using Docker compose, you can use the command below to start the multi-container environment defined in the Docker compose file. Run this command in the same directory as your Dockerfile.

  ```bash
    docker-compose up -d
   ```


