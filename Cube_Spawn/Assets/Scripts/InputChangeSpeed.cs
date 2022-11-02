using System.Collections;
using System.Collections.Generic;
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

    // Update is called once per frame
    void Update()
    {
        Changespeed = mytext.text.ToString();
    }
}
