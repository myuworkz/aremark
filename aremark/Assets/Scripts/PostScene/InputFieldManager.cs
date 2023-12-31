﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputFieldManager : MonoBehaviour
{
    //InputFieldを格納するための変数
    public InputField inputField;

    //メッセージ
    public string letter;

    // Start is called before the first frame update
    void Start()
    {
        //InputFieldコンポーネントを取得
        inputField = GameObject.Find("InputField").GetComponent<InputField>();
    }


    //入力された名前情報を読み取ってコンソールに出力する関数
    public void GetInputLetter()
    {
        //InputFieldからテキスト情報を取得する
        letter = inputField.text;
        inputField.GetComponent<post_text>().letter = letter;
        Debug.Log(letter);

        //送信
        inputField.GetComponent<post_text>().SendSignal_Button_Push();

        //入力フォームのテキストを空にする
        inputField.text = "";
    }


    //キーボード
    private TouchScreenKeyboard keyboard;

   //ボタンタップ
    public void SelectButton()
    {
        this.keyboard = TouchScreenKeyboard.Open("", TouchScreenKeyboardType.Default);
       //後から変更も可能
        this.keyboard.text = "キーボードに入れるテキスト";
    }

    void UpdateKey()
    {
        if (keyboard != null && keyboard.status == TouchScreenKeyboard.Status.Done)
        {
           
        }

    }
}