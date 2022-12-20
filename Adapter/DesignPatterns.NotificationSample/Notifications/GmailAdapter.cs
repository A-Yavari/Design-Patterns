using GmailService;

namespace DesignPatterns.NotificationSample.Notifications;

public class GmailAdapter : ISendMessage
{
    GmailServiceGoogle gmailService = new GmailServiceGoogle();
    public void Send(string Text)
    {
        gmailService.SendMail(Text);
    }
}
