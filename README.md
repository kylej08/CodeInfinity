# CodeInfinity

## How to run
The following program is required:
  1. Visual Studio (the community edition can be found here: https://visualstudio.microsoft.com/vs/community/).

Clone the project, and then open the solution file (CodeInfinity.sln). The solution comes with 2 projects (Test1 and Test2). 
In order to run Test1, right-click on it, and select "Set Startup Project". Once done, the application can be run (in this case, Test1 will run).
The same process applies to run Test2.

Note that if you receive any errors when opening or running the application, then you are likely missing the .NET 5.0 SDK.
The .NET 5.0 SDK can be found here: https://dotnet.microsoft.com/en-us/download/visual-studio-sdks.

Test2 utilises a SQLite database. If you would like to have a graphical view of the data, you can use an application like DB Browser (https://sqlitebrowser.org/dl/).

## License Notice
1. The application uses dapper (https://dapper-tutorial.net/), released under Apache2 license, which can be found in the Test2/NOTICE file.

## Time spent

Below is the time spent on this project (the total off by maybe around 15m-25m).

Test 1: 7h 46m
Test 2: 10h 25m

Total = 18h 11m + Github-related time spent (20m) = 18h 31m

Prior to starting the application as a desktop application, I have spent time (7h 13m) on attempting a web-based version, where some of that time spent was useful in the desktop application (such as learning about mongo). To also count that time, the total might come around to 20h-21h.




