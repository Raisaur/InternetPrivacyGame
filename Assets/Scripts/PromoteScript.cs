using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class PromoteScript : MonoBehaviour
{
    [SerializeField]
    Button btn_ok;

    [SerializeField]
    Text window_text;
    [SerializeField]
    Text button_text;

    [SerializeField]
    String[] window_messages;
    [SerializeField]
    String[] button_messages;

    Vector3 original_pos;
    Vector3 hide_pos;

    float timer = 0.0f;
    float time_limit = 20.0f;
    float start_time = 0.0f;

    float move_speed = 360.0f;
    float journey_length = 0.0f;
    bool show = false;
    bool move = false;

    void Start()
    {
        btn_ok.onClick.AddListener(ClickOk);
        original_pos = gameObject.transform.localPosition;
        journey_length = Vector3.Distance(original_pos, hide_pos);
        hide_pos = new Vector3(original_pos.x + gameObject.GetComponent<RectTransform>().rect.width, original_pos.y, original_pos.z);
        transform.localPosition = hide_pos;
    }

    void Update()
    {
        if (timer > 0)
            timer -= Time.deltaTime;
        if (timer < 0)
            DisplayHide();

        if (move)
            MoveWindow();

        if (show && transform.localPosition == original_pos)
            move = false;
        else if (!show && transform.localPosition == hide_pos)
            move = false;
    }

    public void DisplayShow()
    {
        start_time = Time.time;
        show = true;
        move = true;
    }

    void DisplayHide()
    {
        start_time = Time.time;
        show = false;
        move = true;
    }

    public void SetText1()
    {
        window_text.text = window_messages[0];
        button_text.text = button_messages[0];
    }

    public void SetText2()
    {
        window_text.text = window_messages[1];
        button_text.text = button_messages[1];
    }

    void MoveWindow()
    {
        float dist_covered = (Time.time - start_time) * move_speed;
        float fraction_of_journey = dist_covered / journey_length;

        if (show)
            transform.localPosition = Vector3.Lerp(hide_pos, original_pos, fraction_of_journey);
        else
            transform.localPosition = Vector3.Lerp(original_pos, hide_pos, fraction_of_journey);
    }

    void ClickOk()
    {
        DisplayHide();
    }
}
