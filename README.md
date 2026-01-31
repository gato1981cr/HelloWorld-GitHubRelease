# Hello World GitHub Release Example

This project demonstrates how to create a simple C# "Hello World" application and set up a GitHub Actions workflow to automate the release process.

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

## How to Run the Application

1. Clone the repository to your local machine.
2. Navigate to the `src` directory.
3. Open the `HelloWorld.cs` file and build the project using your preferred C# development environment.
4. Run the application. You should see the output:

   ```
   Hello, World!
   ```

## GitHub Actions Workflow

This project includes a GitHub Actions workflow located in `.github/workflows/release.yml`. This workflow is triggered on new releases and automates the process of building the project and publishing the release.

### Steps in the Workflow

1. **Trigger**: The workflow is triggered when a new release is published.
2. **Build**: The project is built using the .NET CLI.
3. **Release**: The built application is packaged and uploaded as a release asset.

For more details on how to customize the workflow, refer to the `release.yml` file in the `.github/workflows` directory.