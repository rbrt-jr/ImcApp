using ImcApp.Models;

namespace ImcApp;
//para armazenar os outputs no browser, esta é uma das formas
public static class AppState
{
    public static List<ImacModel> History { get; set; } = new();
    
    public static event EventHandler<EventArgs> OnChanged;

    public static void NotifyChanged(object? sender, EventArgs e)
    {
        OnChanged.Invoke(sender, e);
    }
}