using UnityEngine;

public interface IWebSocketFactory
{
    IWebSocket CreateWebSocket(string url);
}

public class WebSocketFactory : IWebSocketFactory
{
    public IWebSocket CreateWebSocket(string url)
    {
        return new WebSocketImplementation(url);
    }
}
