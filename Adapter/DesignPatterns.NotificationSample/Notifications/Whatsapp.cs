namespace DesignPatterns.NotificationSample.Notifications;

public class Whatsapp : ISendMessage
{
    public void Send(string Text)
    {
        Console.WriteLine(Text);
        Console.WriteLine($"Send Message With {nameof(Whatsapp)}  class....");
    }
}
