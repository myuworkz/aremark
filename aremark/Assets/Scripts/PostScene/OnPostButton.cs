using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnPostButton : MonoBehaviour
{
    //InputFieldを格納するための変数
    InputField inputField;

    //メッセージ
    string letter;

    public void PostInputLetter()
    {
        //InputFieldからテキスト情報を取得する
        letter = inputField.text;
        Debug.Log(letter);

        //入力フォームのテキストを空にする
        inputField.text = "";
    }
}
