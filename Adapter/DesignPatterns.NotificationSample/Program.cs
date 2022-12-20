using DesignPatterns.NotificationSample.Notifications;


ISendMessage telegram = new Telegram();
telegram.Send("my test message");

ISendMessage whatsapp = new Whatsapp();
whatsapp.Send("my message");

GmailService.GmailServiceGoogle gmailServiceGoogle = new GmailService.GmailServiceGoogle();
gmailServiceGoogle.SendMail("test message");

ISendMessage gmail = new GmailAdapter();
gmail.Send("my test message ");

Console.ReadLine();
