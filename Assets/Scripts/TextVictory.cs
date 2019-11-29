using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextVictory : MonoBehaviour
{
    // Start is called before the first frame update
    public static TextVictory textVictory;
    
    public Text victoryText;
    void Start()
    {
        textVictory = this;
    }

    // Update is called once per frame
    public void ShowText()
    {
        victoryText.text = "¡Encontraste el tesoro!";
    }
}
