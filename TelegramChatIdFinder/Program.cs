using Telegram.Bot;

var token = "";
var botClient = new TelegramBotClient(token);
Console.WriteLine("Send a message to your telegram bot.");

int offset = 0;
while (true)
{
    var messages = await botClient.GetUpdatesAsync(offset);

    foreach (var item in messages)
    {
        offset = item.Id + 1;
        Console.WriteLine($"ChatId: {item.Message.Chat.Id} => UserName: {item.Message.Chat.Username}");
    }

    await Task.Delay(1000);
}