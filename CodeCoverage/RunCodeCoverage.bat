cd CodeCoverage.Tests

:: The next 2 lines can be removed if the package and report tool are installed
dotnet add package coverlet.collector
dotnet tool install -g dotnet-reportgenerator-globaltool
dotnet test --collect:"XPlat Code Coverage"
reportgenerator.exe "-reports:TestResults\*\*.*.xml" "-targetdir:report"
start report/index.html