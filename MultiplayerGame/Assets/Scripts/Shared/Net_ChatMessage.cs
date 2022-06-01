using System.Collections;
using System.Collections.Generic;
using Unity.Networking.Transport;
using UnityEngine;

public class Net_ChatMessage : NetWorkMessage
{
    public string ChatMessage { set; get; }
    public Net_ChatMessage(string msg)
    {
        dataType = DataTypes.CHAT_MESSAGE;
        ChatMessage = msg;
    }
    public override void Serialize(ref DataStreamWriter writer)
    {
        writer.WriteByte((byte)dataType);
        writer.WriteFixedString128(ChatMessage);
    }

    public override void Deserialize()
    {

    }
}
