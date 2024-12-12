# String Calculator Kata

## Project Overview
This project is an implementation of the String Calculator Kata using Test-Driven Development (TDD) in C# .NET Core 8. The kata is a simple exercise designed to practice TDD principles and improve coding skills.

## Prerequisites
- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Visual Studio Code](https://code.visualstudio.com/) (or your preferred IDE)
- Git

## Project Structure
```
StringCalculatorKata/
│
├── StringCalculatorKata/           # Main project
│   ├── StringCalculator.cs
│   └── StringCalculatorKata.csproj
│
├── StringCalculatorKata.Tests/     # Unit Tests
│   ├── StringCalculatorTests.cs
│   └── StringCalculatorKata.Tests.csproj
│
└── StringCalculatorKata.sln
```

## Installation

### Clone the Repository
```bash
git clone https://github.com/yourusername/StringCalculatorKata.git
cd StringCalculatorKata
```

### Restore Dependencies
```bash
dotnet restore
```

## Running Tests
```bash
# Run all tests
dotnet test

# Watch mode (continuous testing)
dotnet watch test
```

## TDD Approach
This project follows the Test-Driven Development (TDD) methodology:
1. Write a failing test
2. Write minimal code to make the test pass
3. Refactor
4. Repeat

### Kata Steps Implemented
- [x] Handle empty string
- [x] Sum single number
- [x] Sum multiple numbers
- [x] Support comma and new line delimiters
- [x] Support custom delimiters
- [x] Throw exception for negative numbers

## Kata Requirements
The String Calculator should:
- Return 0 for an empty string
- Return the number for a single number
- Sum multiple numbers separated by commas
- Support new line as an alternative delimiter
- Support custom delimiters
- Throw an exception for negative numbers

## Recommended Tools
- [xUnit](https://xunit.net/) for unit testing
- [Visual Studio Code](https://code.visualstudio.com/)
- [C# extension for VS Code](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp)

## Contributing
1. Fork the repository
2. Create your feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## Contact
Meet Sundrani - meetsundrani@gmail.com

Project Link: (https://github.com/meetsundrani/StringCalculatorKata)
