defmodule MyWebSocketAppTest do
  use ExUnit.Case
  doctest MyWebSocketApp

  test "greets the world" do
    assert MyWebSocketApp.hello() == :world
  end
end
