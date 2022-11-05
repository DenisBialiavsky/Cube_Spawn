using UnityEngine;
using UnityEngine.UI;

public class InputChangeSpeed : MonoBehaviour
{
    public static string Changespeed;
    private Text mytext; 

    void Start()
    {
        mytext = GetComponent<Text>();
    }

    void Update()
    {
        Changespeed = mytext.text.ToString();
    }
}
