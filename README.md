# XR Communication Board

A simple XR prototype built with the [StereoKit](https://stereokit.net/) XR library. It demonstrates a simple letter board that can be used to assist non-verbal people with communication.



## Requirements

- .NET SDK 9 or newer
- Android Studio (for building to Android headsets like Meta Quest, etc.)

## How to Run

This project uses the modern [.NET SDK](https://dotnet.microsoft.com/en-us/). Make sure you have it installed! You can follow along with the [StereoKit Getting Started](https://stereokit.net/Pages/Guides/Getting-Started.html) to get the .NET SDK set up.

Then,
- Clone this GitHub repository.
- Open the project in VSCode.
- Build and run using the standard .NET command: `dotnet run`
- For hot reloading: `dotnet watch`
- To build and run to an Android device: `dotnet run --project .\Projects\Android\xr-comms-board.Android.Android.csproj`

## Project Structure

- `Program.cs`: Main entry point for the application.
- `Assets/`: Media assets (images, shader, models, etc.)
- `Projects/Android/`: Android-specific project files.
- `.github/copilot-instructions.md`: Workspace instructions for Copilot.

## Documentation

Refer to the [StereoKit documentation](https://stereokit.net/) for more details on development and APIs.
