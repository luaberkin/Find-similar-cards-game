using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIController : MonoBehaviour
{
    public Button startBtn;
    public TMP_Text testText; 
    // Start is called before the first frame update
    void Start()
    {
        startBtn.onClick.AddListener(ButtonFunction);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Function for checking the Button
    public void ButtonFunction() {
        testText.text = "Button is clicked!";
    }

}
