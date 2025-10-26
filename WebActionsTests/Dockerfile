# Use the .NET SDK image since we need to run tests
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS test

WORKDIR /src

# Copy the solution and projects
COPY ["WebActions/WebActions.csproj", "WebActions/"]
COPY ["WebActionsTests/WebActionsTests.csproj", "WebActionsTests/"]

# Restore dependencies for the solution (both projects)
RUN dotnet restore "WebActionsTests/WebActionsTests.csproj"

# Copy the rest of the source
COPY . .

# Set working directory to the test project
WORKDIR "/src/WebActionsTests"

# Run the tests when this container starts
ENTRYPOINT ["dotnet", "test", "--logger:trx;LogFileName=test_results.trx"]
