# XR Communication Board

A simple XR prototype of a communication board, built with the [StereoKit](https://stereokit.net/) library! It demonstrates a letter board that can be used to assist with communication.

![Demo of the XR Communication Board in action](demo.gif)

## Requirements

- [.NET SDK 9](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) or newer
- [Android Studio](https://developer.android.com/studio) (for building to Android XR headsets, like Meta Quest)

## How to Run

This project uses the .NET SDK. Make sure you have it installed by following the [StereoKit Getting Started Guide](https://stereokit.net/Pages/Guides/Getting-Started.html).

1. Clone this repository.
2. Open the project in your preferred code editor.
3. Run the application using the following commands:

    **For PC-VR.**
    ```shell
    dotnet run
    ```
    
    **For Android Devices:**
    ```shell
    dotnet run --project ./Projects/Android/xr-comms-board.Android.csproj
    ```