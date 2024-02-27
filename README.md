# Guess-the-name
# Guess the Name - Server-Client Application

## Overview

Guess the Name is an engaging multiplayer word guessing game implemented as a client-server application in C#. This project offers an immersive gaming experience with features designed to enhance gameplay and ensure seamless interaction between players.

## Key Features

### Server-side Management
- **Efficient Player Connection Handling:** The server efficiently manages player connections and handles room maintenance to ensure smooth gameplay.
- **Real-time Game Logic Processing:** Game logic is processed in real-time on the server to synchronize gameplay and maintain consistency across clients.

### Client-side Experience
- **Interactive Graphical Interface:** Players are presented with an interactive graphical interface that enhances the gaming experience and facilitates seamless interaction.
- **Room Creation and Joining:** Players can create new rooms or join existing ones, choosing from a variety of categories to tailor their gaming experience.
- **Spectating:** Spectator mode allows players to observe ongoing games, adding an additional layer of engagement to the gameplay experience.

### Game Mechanics
- **Dynamic Word Selection:** Words are dynamically selected based on chosen categories, ensuring variety and excitement in gameplay.
- **Intuitive Turn-based Gameplay:** Gameplay follows a turn-based structure, with players taking turns guessing characters to reveal the hidden word.
- **Winner Determination:** Clear winner determination mechanics are implemented, with congratulatory messages delivered upon victory.
- **Post-game Options:** Players have the option to continue playing after a game or exit the application as desired.

### Logging
- **Persistent Game Results:** Game results are stored persistently on the server-side, providing players with a record of their gaming history and progress.

## Getting Started

### Prerequisites
- C# development environment (e.g., Visual Studio)
- Basic understanding of C# programming, networking concepts, and software development principles

### Cloning the Repository
```bash
git clone[https://github.com/MohamedAbdou2/Guess-the-name.git]
```
*Use code with caution.*

### Setting Up the Project
- Open the solution file (.sln) in your C# development environment.
- Ensure all project dependencies are installed (refer to documentation if needed).

### Running the Application

#### Server
- Locate the GuessTheName.Server project within the solution.
- Set the project as the startup project.
- Press F5 or run the project to start the server.

#### Client
- Locate the GuessTheName.Client project within the solution.
- Build the project (usually through Ctrl+Shift+B or the Build menu).
- Navigate to the project's bin folder (e.g., bin\Debug) and double-click the executable file (.exe) to launch the client application.

### Playing the Game
- Connect to the running server from the client application.
- Create or join a room, choosing categories as desired.
- If joining an existing room, wait for another player or spectate the ongoing game.
- Once paired with another player, take turns guessing characters to reveal the hidden word and claim victory.

## Additional Notes

- Refer to the code comments within the projects for more detailed guidance and insights into specific functionalities.
- Consider exploring the provided resources to delve deeper into C# programming, networking, and software development best practices.
