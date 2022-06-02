using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserLogin : MonoBehaviour
{
    public InputField username;
    public InputField password;

    
    private string url = "https://studenthome.hku.nl/~jogchum.hofma/NetworkingJogchum/UnityTest.php?id=4";

    public void Button()
    {
        StartCoroutine(Login());
    }

    IEnumerator Login()
    {
        WWW www = new WWW(url);

        yield return www;

        if (www.error != null)
        {
            print("php Request error: Code is" + www.error);
        }
        else
        {
            print("php Request succeeded " + www.text);
        }
    }

    
}
