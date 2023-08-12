# Unity Phone Login with WebSocket

This Unity project demonstrates a simple phone number login functionality using WebSocket communication. The project allows users to input their phone numbers, initiate a WebSocket connection to a server, and receive status updates through a text UI element.

## Features

- **Phone Number Login:** Users can input their phone numbers for login.
- **WebSocket Communication:** The project uses the WebSocketSharp library to establish a WebSocket connection to a server.
- **Status Updates:** Users receive real-time status updates in a text UI element.
- **Debug Logging:** Debug logs are provided to track the progress of the WebSocket connection and data exchange.
- **Clean UI:** The project features a clean user interface with an input field and a button.

## Getting Started

1. Clone the repository to your local machine.
2. Open the Unity project using Unity Editor.
3. Attach the `PhoneLogin` script to an empty GameObject.
4. Make sure to set up the UI elements (`StatusText`, `PhoneNumberInput`, and a Button) in the hierarchy.
5. Adjust the WebSocket server URL in the `InitiateWebSocketConnection` method.
6. Run the project in the Unity Editor.

## Dependencies

- Unity 2022.3.2f1 (or later)
- WebSocketSharp library

## Usage

1. Run the Unity project in the Unity Editor.
2. Input your phone number in the UI input field.
3. Click the "Login" button to initiate a WebSocket connection.
4. Observe the status updates in the UI and the Unity Console.
5. Experiment further by extending the project's functionality and integrating it with your own WebSocket server.

## Contributing

Contributions are welcome! Feel free to open issues and pull requests for any improvements, bug fixes, or new features.

## License

This project is licensed under the [MIT License](LICENSE).


## ScreenShots

![LoginScreen](https://github.com/lukeiceslinger/Websocket-Phoenix/blob/main/LoginScreen.png?raw=true)

![LoggedInScreen](https://github.com/lukeiceslinger/Websocket-Phoenix/blob/main/LoggedInScreen.png?raw=true)


