# Verifiabled

This project contains all core assertion logic. There is no test execution context in here.

## Requirements

- .NET10

## Installation

1. Create new test project

    ```powershell
    dotnet new classlib
    ```

2. Install all required NuGets

    ```powershell
    dotnet add package Microsoft.Net.Test.SDK
    dotnet add package Verifiabled --prerelease
    dotnet add package Verifiabled.TestAdapter --prerelease
    ```

3. Done!

    You can now create and execute test cases.

## Usage

1. Create new public class

    ```csharp
    public sealed class ExampleTestSet
    {
        [Case]
        public void ExampleTestCase()
        {
            Assert.IsTrue(true);
        }
    }
    ```

2. Execute your tests

    - using Visual Studio
    - using dotnet command `dotnet test -v YoursTestProject.dll`


## Roadmap

Please see [ROADMAP.md](./Docs/ROADMAP.md).