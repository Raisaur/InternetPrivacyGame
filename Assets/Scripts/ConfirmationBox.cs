using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public enum ConfirmationResults
{
    ResNull,
    ResYes,
    ResNo
}

public class ConfirmationBox : MonoBehaviour
{
    [SerializeField]
    Button btn_yes, btn_no;
    [SerializeField]
    Text text;

    String message;
    String original_message;
    Action function;

    ConfirmationResults result = ConfirmationResults.ResNull;

    // Start is called before the first frame update
    void Start()
    {
        btn_yes.onClick.AddListener(ClickYes);
        btn_no.onClick.AddListener(ClickNo);
        original_message = text.text;
        gameObject.SetActive(false);
    }

    public void SetAction(Action use_function) { function = use_function; }

    public void SetMessage(string m) { message = m; }

    public void ShowConfirmationBox()
    {
        gameObject.SetActive(true);
        //text.text = original_message;
        result = ConfirmationResults.ResNull;
        function = null;
    }

    public void HideConfirmationBox() { gameObject.SetActive(false); }

    public ConfirmationResults ReturnResult() { return result; }

    void ClickYes()
    {
        result = ConfirmationResults.ResYes;
        function.Invoke();
    }

    void ClickNo()
    {
        result = ConfirmationResults.ResNo;
    }
}
