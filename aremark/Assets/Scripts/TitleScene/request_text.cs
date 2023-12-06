using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class request_text : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(HttpConnect());
    }

    private IEnumerator HttpConnect()
    {
        string url = "localhost/request_text.php";

        //Unity2018~
        UnityWebRequest uwr = UnityWebRequest.Get(url);
        yield return uwr.SendWebRequest();

        if (uwr.isHttpError || uwr.isNetworkError)
        {
            Debug.Log(uwr.error);
        }
        else
        {
            Debug.Log(uwr.downloadHandler.text);
        }
    }
}
