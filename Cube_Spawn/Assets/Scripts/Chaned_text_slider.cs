using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Chaned_text_slider : MonoBehaviour
{
    public Slider slider;
    public Text text;

    void Awake()
    {
        text = GetComponentInChildren<Text>();
        slider = GetComponent<Slider>();
    }

    public void ShowSliderValue()
    {
        text.text = slider.value.ToString();
    }
}
