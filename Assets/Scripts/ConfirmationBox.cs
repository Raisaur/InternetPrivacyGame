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
    GameObject Panel;

    Action function;

    ConfirmationResults result = ConfirmationResults.ResNull;

    // Start is called before the first frame update
    void Start()
    {
        btn_yes.onClick.AddListener(ClickYes);
        btn_no.onClick.AddListener(ClickNo);
    }

    public void SetAction(Action use_function)
    {
        function = use_function;
    }

    public void ShowConfirmationBox()
    {
        gameObject.SetActive(true);
        result = ConfirmationResults.ResNull;
        function = null;
    }

    public void HideConfirmationBox()
    {
        gameObject.SetActive(false);
    }

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
