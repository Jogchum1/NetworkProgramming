using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ChatMessageTest : MonoBehaviour
{

    [SerializeField] private InputField chatInput;

    public void OnSubmitClick()
    {
        Net_ChatMessage msg = new Net_ChatMessage(chatInput.text);
        FindObjectOfType<Client>().SendToServer(msg);
    }
}
