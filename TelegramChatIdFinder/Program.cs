using Telegram.Bot;

var token = "";
var botClient = new TelegramBotClient(token);

var messages = await botClient.GetUpdatesAsync();

foreach (var item in messages)
{
    Console.WriteLine($"ChatId: {item.Message.Chat.Id} => UserName: {item.Message.Chat.Username}");
}

Console.ReadLine();
