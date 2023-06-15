# Arduino Traffic Light Control With Timer (C# GUI)

This repository contains two parts of a project controlling an Arduino-based traffic light system from a Windows Forms Application. 

## Arduino 

The Arduino program controls a traffic light system with three lights: Green, Yellow and Red. Each light is connected to a separate pin, and the duration for which each light stays on is defined within the program. The program listens for serial inputs, which allow for changing the state of the traffic lights.

## C# Windows Forms Application 

The C# program provides a GUI for interacting with the Arduino program. It communicates with the Arduino program over a serial port, sending commands to change the state of the traffic lights. A timer is displayed next to each light, indicating the remaining time for the current light state. 

## Getting Started

1. Clone this repo locally.
2. Open the Arduino code in the Arduino IDE and upload it to your Arduino board.
3. Open the C# solution in Visual Studio and run the program. 
4. Ensure the C# application is configured to use the correct COM port that your Arduino is connected to.

## Requirements

- .NET Framework (for the C# GUI)
- Arduino IDE

## Contributing

If you have suggestions for how this project could be improved, or want to report a bug, open an issue! Contributions of all kinds are welcomed!



