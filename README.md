# WeaponSway

WeaponSway is a script written in C# for Unity that provides a weapon sway effect and implements a simple interaction mechanic based on the player's view direction.

## Features

- Weapon sway effect that mimics the movement of a weapon in response to mouse input.
- Interaction mechanic: If the player looks at a specific game object with sufficient precision, it will be destroyed.

## Prerequisites

- Unity Engine (version X.X.X)
- Any IDE or code editor (e.g., Visual Studio, Visual Studio Code)

## Getting Started

To get started with WeaponSway, follow these steps:

1. Clone the repository or download the project files.
2. Open the project in Unity.
3. Open the `WeaponSway` script located in the `Scripts` folder.
4. Attach the `WeaponSway` script to the game object representing the weapon.
5. Adjust the sway settings and any other desired parameters in the inspector.
6. Run the game or simulate the scene in the Unity Editor.

## Usage

- The `multiplier` field determines the sensitivity of the weapon sway effect. Adjust it to achieve the desired amount of movement.
- The `smooth` field controls the smoothness of the weapon rotation. Higher values result in slower rotations, while lower values result in faster rotations.
- The `preciseness` field sets the level of precision required for the player to interact with a specific game object. Modify this value according to your gameplay requirements.
- Attach the `WeaponSway` script to the game object representing the player's weapon.
- Run the game or simulate the scene to see the weapon sway effect in action.

## Example

```csharp
using System;
using UnityEngine;

public class WeaponSway : MonoBehaviour
{
    // ... script code ...
}

License
This project is licensed under the MIT License.

Contributing
Contributions are welcome! If you find any issues or have suggestions for improvements, please open an issue or submit a pull request.

Acknowledgments
This script was inspired by [insert inspiration here].
Special thanks to [insert names] for their contributions and support.


Feel free to customize and modify this README file to suit your specific project needs.


