
# Hello World GitHub Release Example

This repository demonstrates how to automate the release process of a simple C# "Hello World" application using GitHub Actions. It is designed as an educational example to help you understand and replicate a basic CI/CD workflow for .NET projects.

## What This Project Demonstrates

- How to structure a minimal C# project for version control and CI/CD.
- How to configure a GitHub Actions workflow to build, publish, and release a .NET application automatically when a new tag is pushed.
- The basics of tagging releases in Git and how this triggers automated workflows.
- Best practices for open source project automation.

## Prerequisites

To run, build, and experiment with this project, you will need:

- **.NET SDK 6.0 or later** ([Download .NET](https://dotnet.microsoft.com/download))
- **Git** ([Download Git](https://git-scm.com/downloads))
- A **GitHub account**
- (Recommended) **Visual Studio Code** or **Visual Studio 2022+** for easier editing and debugging
- (Optional) **GitHub CLI** ([Download GitHub CLI](https://cli.github.com/)) for advanced repository management

## Recommendations

- Use Visual Studio Code with the C# and GitHub Actions extensions for the best experience.
- Familiarize yourself with basic Git commands and GitHub repository management.
- Review the [GitHub Actions documentation](https://docs.github.com/en/actions) to understand workflow syntax and capabilities.

## Project Structure

## Project Structure

```
HelloWorld-GitHubRelease
├── src
│   └── HelloWorld.cs
├── .github
│   └── workflows
│       └── release.yml
├── HelloWorld-GitHubRelease.sln
└── README.md
```


## How to Run the Application Locally

1. Clone the repository to your local machine:
   ```sh
   git clone https://github.com/your-username/HelloWorld-GitHubRelease.git
   cd HelloWorld-GitHubRelease
   ```
2. Build the project:
   ```sh
   dotnet build ./HelloWorld-GitHubRelease.sln
   ```
3. Run the application:
   ```sh
   dotnet run --project ./src/HelloWorld.cs
   ```
   You should see the output:
   ```
   Hello, World!
   ```


## How the GitHub Actions Workflow Works

The workflow file is located at `.github/workflows/release.yml`. It automates the following steps:

1. **Trigger**: The workflow runs when you push a tag that matches the pattern `v*.*.*` (e.g., `v1.0.0`).
2. **Build**: Checks out the code, sets up the .NET environment, restores dependencies, and builds the project in Release mode.
3. **Publish**: Publishes the compiled application to the `output` directory.
4. **Release**: Creates a new GitHub Release and uploads the published files as release assets.

### How to Trigger the Workflow

1. Make sure all your changes are committed:
   ```sh
   git add .
   git commit -m "Your message"
   git push
   ```
2. Create a new tag (e.g., `v1.0.0`):
   ```sh
   git tag v1.0.0
   git push origin v1.0.0
   ```
3. The workflow will start automatically. You can monitor progress in the GitHub Actions tab of your repository.

## Customization

- You can modify the workflow file to add tests, change build configurations, or upload different assets.
- For more details, see the comments in `.github/workflows/release.yml` and the [GitHub Actions documentation](https://docs.github.com/en/actions).

---

This project is intended as a learning resource for anyone interested in automating .NET releases with GitHub Actions.