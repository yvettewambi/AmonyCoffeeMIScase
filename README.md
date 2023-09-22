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

**To build and run the application using Docker**

1. Clone/Fork the Repo.

2. Download and install the latest version of Visual Studio (https://visualstudio.microsoft.com/)

3. Install the required Visual Studio workloads for the application.

   ![Screenshot 2023-09-22 153442](https://github.com/yvettewambi/AmonyCoffeeMIScase/assets/84707601/585efd55-8475-4648-bf13-6cecc797b6e0)

5. Download and Install Docker Desktop (https://docs.docker.com/desktop/install/windows-install/) 

6. Build the Container image in Visual Studio by right clicking on the main solution file (AmonyCoffeeMIS) and then select Build/Rebuild solution or you can select the Docker file and select Build Docker image.

   ![Screenshot 2023-09-22 130430](https://github.com/yvettewambi/AmonyCoffeeMIScase/assets/84707601/5243d831-b69e-438a-aa97-a8cbca1ee631)  

8. In Visual Studio select the required configuration (Debug) in this case during development and then click the run button to start the Docker. This will start the Docker Container on a random port which will automatically pop up in your browser.

   ![Screenshot 2023-09-22 130818](https://github.com/yvettewambi/AmonyCoffeeMIScase/assets/84707601/2315a62d-e098-4dc3-b744-733bc654a8fe)


Optional Configuration

* To start the container(s) using Docker compose, you can use the command below to start the multi-container environment defined in the Docker compose file. Run this command in the same directory as your Dockerfile.

  ```bash
    docker-compose up -d
   ```
* You can also enable Container orchestration support in Visual Studio inorder to run multiplte containers in docker compose without having to manually run the docker compose commands.


