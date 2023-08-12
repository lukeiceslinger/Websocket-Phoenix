using UnityEngine;
using UnityEngine.UI;
using WebSocketSharp;
using TMPro;

public class PhoneLogin : MonoBehaviour
{
    public TextMeshProUGUI statusText;
    public TMP_InputField phoneNumberInput;
    private WebSocket socket;
    [SerializeField] private Button loginButton;

    private void Awake()
    {
        loginButton = GameObject.FindGameObjectWithTag("loginButton").GetComponent<Button>();
    }

    private void Start()
    {
        // Access UI elements by finding them in the hierarchy
        statusText = GameObject.Find("StatusText").GetComponent<TextMeshProUGUI>();
        phoneNumberInput = GameObject.Find("PhoneNumberInput").GetComponent<TMP_InputField>();

        // Cache the Button component and subscribe to the button click event
        //Button loginButton = GetComponent<Button>();
        loginButton.onClick.AddListener(OnLoginButtonClick);
    }

    private void OnLoginButtonClick()
    {
        string phoneNumber = phoneNumberInput.text;

        // Update status text
        statusText.text = $"Logging in with phone number: {phoneNumber}";

        // Debug log to indicate the process has started
        Debug.Log("WebSocket connection process started");

        // Initiate WebSocket connection
        InitiateWebSocketConnection(phoneNumber);
    }

    private void InitiateWebSocketConnection(string phoneNumber)
    {
        // Replace "ws://your-server-url" with your actual WebSocket server URL
        socket = new WebSocket($"ws://localhost:3000");

        // Subscribe to WebSocket events
        socket.OnOpen += (sender, e) =>
        {
            Debug.Log("WebSocket connection opened");
            // You can send data to the server after connection is opened
        };
        socket.OnMessage += (sender, e) =>
        {
            Debug.Log("WebSocket message received: " + e.Data);
            // Handle the received data from the server
        };
        socket.OnClose += (sender, e) =>
        {
            Debug.Log("WebSocket connection closed with code: " + e.Code);
            Debug.Log("WebSocket close reason: " + e.Reason);
            // Handle the WebSocket connection closure
        };

        // Connect to the WebSocket server
        socket.Connect();
    }

    private void OnDestroy()
    {
        // Clean up the WebSocket when the script or GameObject is destroyed
        if (socket != null && socket.IsAlive)
        {
            socket.Close();
        }
    }
}
