# Yuxi-3D-Unity-BallRunGame

## Overview

**Yuxi-3D-Unity-BallRunGame** is a small 3D running game prototype built with the Unity game engine. The player controls a rolling ball navigating through an obstacle course. The goal is to reach the finish line while avoiding barriers and utilizing moving platforms (lifts). Background music and skyboxes enhance the immersive gameplay.

## Features

- **3D Ball Control:** Use standard movement keys to roll the ball in any direction.
- **Obstacles & Barriers:** Test your reflexes by dodging or jumping over barriers.
- **Finish Line:** Reach the finish object to complete the level.
- **Moving Platforms (Lifts):** Ride platforms that add verticality and challenge.
- **Background Music:** Enjoy a looping background track to add atmosphere.
- **Basic Materials & Prefabs:** Easily modifiable game elements, allowing customization.

## Project Structure

- **Scripts**
  - `Player.cs` : Handles player movement and input.
  - `Barrier.cs` : Manages barrier behavior and collision.
  - `Finish.cs` : Detects when the player reaches the end of the level.
  - `Lift.cs` : Controls the movement of vertical or horizontal lifts.

- **Prefabs**
  - `Barrier.prefab` : A reusable obstacle that can be placed throughout the level.
  - `BgMusic.prefab` : Prefab holding an audio source for background music.
  
- **Materials**
  - `matBarrier.mat` : Material for obstacles.
  - `matGround.mat` : Material for the ground surface.

- **Scenes**
  - Main scene that contains the player, ground, obstacles, and finish line.
  
- **Executable**
  - `Yuxi-BallRunGame.exe` : A Windows build of the game for quick demo/testing.

## Getting Started

1. **Clone the Repo:**
   ```bash
   git clone https://github.com/yourusername/Yuxi-3D-Unity-BallRunGame.git
2. **Open in Unity:**
- Open Unity Hub
- Select the `Yuxi-3D-Unity-BallRunGame` folder as a project.
3. **Run the Game in Editor:**
- Open the main scene.
- Press the Play button in the Unity Editor.
4. **Build the Game:**
- Go to `File > Build Settings...`.
- Add the main scene to the build.
- Choose your target platform and click "Build" or "Build and Run".

## Controls
- **W/A/S/D or Arrow Keys:** Move the ball.
- **Space (if implemented):** Jump (if jumping is set up in `Player.cs`).

## Contributing
1. Fork this repository.
2. Create a new branch for your feature or bugfix.
3. Commit your changes and push your branch.
4. Open a Pull Request to merge changes back into the main branch.

## License
This project is licensed under the MIT `LICENSE`.
