# Verifiabled

This project contains all core assertion logic. There is no test execution context in here.

## Requirements

- .NET7

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
        // ... test cases go here
    }
    ```

2. Create new public method with Case attribute in this class

    ```csharp
    [Case]
    public void ExampleTestCase()
    {
        // ... test case logic goes here
    }
    ```

3. Write your assertions

    ```csharp
    Assert.That(true).IsTrue();
    ```

4. All done!

    ```csharp
    public sealed class ExampleTestSet
    {
        [Case]
        public void ExampleTestCase()
        {
            Assert.That(true).IsTrue();
        }
    }
    ```

5. You can now execute your tests

    - using Visual Studio
    - using dotnet command `dotnet test -v YoursTestProject.dll`


## Roadmap

Please see [ROADMAP.md](./Docs/ROADMAP.md).