using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MouseOver : MonoBehaviour
{
    [SerializeField] private GameObject background;
    [SerializeField] private TextMeshProUGUI text;

    private void Start()
    {
        text.color = Color.white;
    }

    public void ShowBackground()
    {
        background.SetActive(true);
        text.color = Color.black;
    }

    public void HideBackground()
    {
        background.SetActive(false);
        text.color = Color.white;
    }
}
