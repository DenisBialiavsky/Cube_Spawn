using UnityEngine;
using UnityEngine.UI;

public class Chaned_text_slider : MonoBehaviour
{
    public Slider sliderChangeValue;
    public Text textShowValueOfSlider;
    void Awake()
    {
        textShowValueOfSlider = GetComponentInChildren<Text>();
        sliderChangeValue = GetComponent<Slider>();
    }

    public void ShowSliderValue()
    {
        textShowValueOfSlider.text = sliderChangeValue.value.ToString();
    }
}
