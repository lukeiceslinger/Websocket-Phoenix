defmodule MyWebSocketApp.MixProject do
  use Mix.Project

  def project do
    [
      app: :my_web_socket_app,
      version: "0.1.0",
      elixir: "~> 1.15",
      start_permanent: Mix.env() == :prod,
      deps: deps()
    ]
  end

  # Run "mix help compile.app" to learn about applications.
  def application do
    [
      extra_applications: [:logger]
    ]
  end

  # Run "mix help deps" to learn about dependencies.
  defp deps do
    [
      #{:gun, "~> 1.5"},
      {:websocket_client, "~> 1.5"} 
    ]
  end
end
