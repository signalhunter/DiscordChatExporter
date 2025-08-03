using System.Text.Json;
using DiscordChatExporter.Core.Utils.Extensions;

namespace DiscordChatExporter.Core.Discord.Data;

public partial record Snapshot(MessageSnapshot Message)
{
    public static Snapshot Parse(JsonElement json)
    {
        var message = json.GetProperty("message").Pipe(MessageSnapshot.Parse);

        return new Snapshot(message);
    }
}
