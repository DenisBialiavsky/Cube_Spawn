using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndProgramm : MonoBehaviour
{
    public Button endApplication;
    void Start()
    {
        endApplication.onClick.AddListener(Application.Quit);
    }

    
}
