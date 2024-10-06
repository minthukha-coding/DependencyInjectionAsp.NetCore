using DependencyInjectionInASP.NET_Core.Interfaces;

namespace DependencyInjectionInASP.NET_Core.Services;

public class MyService : IMyService
{
    public string GetMessage()
    {
        return "Hello from MyService!";
    }
    public string GetNickName()
    {
        return "Marko";
    }
}
