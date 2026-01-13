# com.kibalab.udonsharpwatcher

| 🇺🇸 [English](./Packages/com.kibalab.udonsharpwatcher/README.md) | 🇰🇷 [한국어](./Packages/com.kibalab.udonsharpwatcher/README.ko.md) | 🇯🇵 [日本語](./Packages/com.kibalab.udonsharpwatcher/README.ja.md) |

UdonSharpWatcher keeps your Unity project in sync with generated `UdonSharpProgramAsset` files by creating them automatically when a compatible `UdonSharpBehaviour` script is added or modified.

## Features
- Detects new or changed `.cs` scripts that derive from `UdonSharpBehaviour`.
- Skips Unity packages and other cached folders to avoid duplicate assets.
- Creates and imports the matching `.asset` so you can publish to VRChat without writing the asset manually.

## Installation
1. Visit [https://vpm.kiba.red](https://vpm.kiba.red) and copy the repo listing URL for `com.kibalab.udonsharpwatcher`.
2. Add that URL to VRChat Community Client (`vcc://vpm/addRepo?url=<listing-url>`).
2. Search for `com.kibalab.udonsharpwatcher` and install the package.
3. Ensure `UDONSHARP` scripting define symbols are enabled and the VRC SDK dependencies are present (`VRC.SDK3`, `UdonSharp`).