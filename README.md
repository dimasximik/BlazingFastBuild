# BlazingFastBuild for Unity

### Automate your Unity build process for Android and iOS

**BlazingFastBuild** is a tool to streamline and automate Unity builds for Android and iOS. It simplifies repetitive tasks like setting up keystores, choosing build architectures, and managing multiple build configurations directly from Unity's menu.

## Key Features

- **Automated Android APK/AAB builds** with support for both development and release configurations.
- **iOS project generation** for development and release.
- **Keystore management** for signing Android apps (custom development and release keystores).
- **Configurable build settings** stored in a single ScriptableObject for easy maintenance.

## Setup

1. Clone this repository into your Unity project:
    ```bash
    git clone https://github.com/dimasximik/BlazingFastBuild.git
    ```
2. In Unity, use a build config via `Assets/BFG/BFGBuildConfig` and set up paths, keystore details, and other preferences.

## Usage

- **Android**: Use **BFG -> Build -> Android** for APK/AAB builds or **BFG -> BuildAndRun -> Android** to build and run directly on a device.
- **iOS**: Navigate to **BFG -> Build -> iOS** for development and release builds.
- Quickly access build outputs via **BFG -> Open Build Folder**.

## Contributing

This tool was built to save time on repetitive build setups. If you find it useful and have ideas for improvement, feel free to open an issue or submit a pull request. I'll review contributions as time permits.

For direct questions, reach out on Telegram: [@CodeOrDie42](https://t.me/CodeOrDie42).

If time allows, I might add support for more platforms or CI/CD integration, but feel free to contribute if you need these features sooner.
