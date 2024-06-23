# BumberBros-Api

## Overview
BumperBros is a turn-based strategy game where up to 4 players navigate a grid to collect power-ups and engage in combat. Players input their movement directions and the game executes them in sequence. The goal is to outmaneuver and outfight your opponents using strategic moves and power-ups.

## Features
- **Turn-based gameplay**: Players take turns to move their tokens on the board.
- **Up to 4 players**: Players spawn in each of the four corners of the board.
- **Power-ups**: Randomly spawn closer to the middle of the board, providing various bonuses.
- **Combat**: Players can attack each other by moving onto occupied tiles.
- **Game modes**: Multiple game modes including Last Cart Standing, First to 10 Kills, and Capture the Flag.
- **Arena-shrinking mechanic**: The arena shrinks over time, adding a layer of strategy.

## Game Mechanics

### Movement
- Players can input up to 3 movement directions per turn (cardinal directions: N, S, E, W).
- Movements are executed one at a time in player order.
- Players have 60 seconds to input their moves or until all players are ready.

### Power-ups
- **+1 Movement**: Adds an extra movement for the player.
- **+1 Push**: Allows pushing an opponent an additional tile.
- **+1 ATK**: Increases attack damage.
- **+1 DEF**: Reduces incoming damage.
- **Reveal**: Allows seeing other players' next moves.
- **Agility**: Enables diagonal movement.
- **Hearts**: Increase player health.

### Combat
- If a player moves onto an occupied tile, they attack the defender.
- Damage is calculated as attacker's ATK minus defender's DEF, with a minimum of 1 damage.

### Arena Shrinking
- After a certain number of rounds, the arena will shrink.
- A warning banner highlights the tiles that will ignite.
- Players standing on ignited tiles take additional damage and must move inward.

### Power-up Spawn Rules
- Initial power-up spawns at the start of the game.
- Strongest power-up spawns in the center, lesser power-ups spawn equidistant from each other.
- Collected power-ups respawn after three rounds in a random location at least 4 spaces away from all players.
- Players can hold up to two power-ups and must choose when to consume them during the movement phase.

## Tech Stack
- **Backend**: C#, ASP.NET Core Web API, SignalR, ADO.NET, MSSQL/MongoDb
- **Frontend**: React with TypeScript, TailwindCSS
- **Deployment**: Docker, Docker-Compose
- **Pathfinding**: AStar Library

## Development
- Development is managed through issues on GitHub.

## Class Models

### GameService

### Board
- **Tokens**: `List<Token>`

### Token
- **Id**: `int`
- **XLocation**: `int`
- **YLocation**: `int`

### Player (inherits Token)
- **Name**: `string`
- **HP**: `int`
- **ATK**: `int`
- **DEF**: `int`
- **Movement**: `int`
- **Moves**: `List<Move>`
- **PowerUps**: `List<PowerUp>`

### PowerUp (inherits Token)
- **Effect**: `PowerUpEffect`
- **Description**: `string`
- **PickedUp**: `boolean`

## Enums

### Move
- `N`
- `W`
- `E`
- `S`

### PowerUpEffect
- `AddMove`
- `Push`
- `AddATK`
- `AddDEF`
- `Reveal`
- `Agile`

## License
This project is licensed under the MIT License
