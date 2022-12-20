namespace DesignPatterns.NotificationSample.Notifications;

public class Telegram : ISendMessage
{
    public void Send(string Text)
    {
        Console.WriteLine(Text);
        Console.WriteLine($"Send Message With {nameof(Telegram)}  class....");
    }
}
