# K2C-SpiritedAway
A [Kingdom: Two Crowns](https://www.kingdomthegame.com/kingdom-two-crowns) mod that disables the omnipresent ancestral tutorial ghost.

Have you ever wondered why a past self keeps trying to have you build a special tower in a dumb location, or deposit money in the castle right after you deposited money in your castle?  Wonder no more and send them back to the void forever!

This mod disables all appearances of the ghost and automatically completes the intro tutorial to prevent placement of invisible walls.

## Dependencies
Kingdom: Two Crowns is a 32-bit (x86) Unity IL2CPP game and requires the latest IL2CPP support from BepInEx 6.
- [.NET 6 Runtime](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)
- BepInEx 6.0.0+
    - Known Good:  [BepInEx-Unity.IL2CPP-win-x86-6.0.0-be.668+46e297f](https://builds.bepinex.dev/projects/bepinex_be) 
    - Fails to load this plugin:  [BepInEx 6.0.0-pre.1](https://github.com/BepInEx/BepInEx/releases/tag/v6.0.0-pre.1)

## Installation Instructions
1. Install .NET 6 Runtime
1. Unpack BepInEx IL2CPP x86 to `\Kingdom Two Crowns\`
1. **Run Kingdom: Two Crowns once and verify BepInEx loads successfully, then close the game**
1. Unpack `wonkotron-SpiritedAway` to `\Kingdom Two Crowns\BepInEx\plugins`

## Compatibility Notes
Patched methods:
- `GhostHintTrigger.Start()`, Prefix
- `TutorialManager.Init()`, Postfix
