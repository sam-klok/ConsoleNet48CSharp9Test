Playing with new version c# 9.0 and standard .Net Framework 4.8 in Visual Studio 19 
I used Visual Studio 2019 v16.11.19 to create this solution.

Because Properties -> Advanced -> Language version is NOT working in VS 2019, use hack below. 

Under VS 2019 (only recent versions) use LangVersion 9 at .csproj file:

  <PropertyGroup>
    ...
    <LangVersion>9.0</LangVersion>
  </PropertyGroup>


Thank you. 