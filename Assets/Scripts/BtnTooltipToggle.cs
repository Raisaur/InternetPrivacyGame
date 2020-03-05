﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BtnTooltipToggle : MonoBehaviour
{
    [SerializeField]
    Text tooltip;

    void Start()
    {
        tooltip.gameObject.SetActive(false);
    }

    public void ToggleOn()
    {
        tooltip.gameObject.SetActive(true);
    }

    public void ToggleOff()
    {
        tooltip.gameObject.SetActive(false);
    }
}