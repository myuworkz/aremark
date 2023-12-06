using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title2Main : MonoBehaviour
{
    void Start()
    {
        //StartCoroutine(LoadScene());

        this.GetComponent<FadeManager>().LoadScene(1.0, "PostScene");
    }

    private IEnumerator LoadScene()
    {
        //var async = SceneManager.LoadSceneAsync("MainScene");
        var async = SceneManager.LoadSceneAsync("PostScene");

        async.allowSceneActivation = false;
        yield return new WaitForSeconds(1.5);
        async.allowSceneActivation = true;
    }
}
