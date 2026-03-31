# Space Invaders Console

A classic Space Invaders game built for the console using C#.

## Project Status

### ✅ Phase 1: Foundation (In Progress)
- Basic project structure set up
- Console rendering system implemented
- Player movement controls (Arrow Keys/WASD)
- Collision detection framework

### 📋 Phase 2: Core Gameplay (Next)
- Enemy spawning and movement
- Player shooting mechanics
- Basic collision detection
- Score system

## How to Build and Run

### Prerequisites
- .NET 8.0 SDK or higher

### Build
```bash
dotnet build
```

### Run
```bash
dotnet run
```

## Controls

- **Left Arrow** or **A** - Move Left
- **Right Arrow** or **D** - Move Right
- **Space** - Shoot (coming soon)
- **ESC** - Exit Game

## Project Structure

```
space-invaders-console/
├── Program.cs
├── SpaceInvadersConsole.csproj
├── src/
│   ├── Player.cs
│   ├── Collision.cs
│   ├── Enemy.cs (coming soon)
│   ├── Projectile.cs (coming soon)
│   └── GameState.cs (coming soon)
├── game-plan.md
└── README.md
```

## Next Steps

1. Implement Enemy class and spawning
2. Add player shooting mechanics
3. Create projectile collision detection
4. Add scoring system
5. Implement level progression