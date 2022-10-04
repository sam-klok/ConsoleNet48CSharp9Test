Playing with new version c# 9.0 and standard .Net Framework 4.8 in Visual Studio 19 
I used Visual Studio 2019 v16.11.19 to create this solution.
See some comments below.
Thank you. 


Because Properties -> Advanced -> Language version is NOT working in VS 2019, use hack below. 

Under VS 2019 (only recent versions) use LangVersion 9 at .csproj file:

  <PropertyGroup>
    ...
    <LangVersion>9.0</LangVersion>
  </PropertyGroup>




If you are running it in Visual Studio Code, then you may have difficulties because "dotnet run" designed is for .NET Core
Example of build below:

PS C:\Repos\ConsoleNet48CSharp9Test> dotnet build
MSBuild version 17.3.1+2badb37d1 for .NET
  Determining projects to restore...
  Nothing to do. None of the projects specified contain packages to restore.
  ConsoleNet48CSharp9Test -> C:\Repos\ConsoleNet48CSharp9Test\ConsoleNet48CSharp9Test\bin\Debug\ConsoleNet48CSharp9Test.exe

Build succeeded.
    0 Warning(s)
    0 Error(s)

Time Elapsed 00:00:05.27

PS C:\Repos\ConsoleNet48CSharp9Test> C:\Repos\ConsoleNet48CSharp9Test\ConsoleNet48CSharp9Test\bin\Debug\ConsoleNet48CSharp9Test.exe
Name: Serg Klok
Press any key..
PS C:\Repos\ConsoleNet48CSharp9Test> 