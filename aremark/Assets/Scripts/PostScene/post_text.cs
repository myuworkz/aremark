using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using System;

public class post_text : MonoBehaviour
{
    public Text InputText_;
    public int id;
    public string name;
    public double longitude;
    public double latitude;
    public DateTime datetime;
    public string letter;

    public void SendSignal_Button_Push()
    {
        id = 0;//
        name = "";//

        if(Input.location.status == LocationServiceStatus.Running)
        {
            LocationInfo location = Input.location.lastData;
            longitude = location.longitude;
            latitude = location.latitude;
        }
        else
        {
            longitude = 0.0;
            latitude = 0.0;
        }

        datetime = DateTime.Now;

        letter = "";//

        //送信開始
        StartCoroutine(HttpConnect());
    }

    private IEnumerator HttpConnect()
    {
        WWWForm form = new WWWForm();
        form.AddField("id", id);
        form.AddField("name", name);
        form.AddField("longitude", longitude.ToString());
        form.AddField("latitude", latitude.ToString());
        form.AddField("datetime", datetime.ToString());
        form.AddField("letter", InputText_.GetComponent<Text>().text);

        string url = "localhost/post_text.php";
        UnityWebRequest uwr = UnityWebRequest.Post(url, form);
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
