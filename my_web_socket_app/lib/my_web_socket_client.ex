defmodule MyWebSocketClient do
    @server_url "ws://localhost:3000"
  
    def connect_and_send_message() do
      case :websocket_client.connect(@server_url, nil) do
        {:ok, pid} ->
          IO.puts("WebSocket connection established")
          send_message(pid, "Hello from Elixir!")
        {:error, reason} ->
          IO.puts("WebSocket connection error: #{reason}")
      end
    end
  
    defp send_message(pid, message) do
      :websocket_client.send_text(pid, message)
      IO.puts("Message sent: #{message}")
      :websocket_client.close(pid)
    end
  end
  