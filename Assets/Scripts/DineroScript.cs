using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DineroScript : MonoBehaviour
{
    public TMP_Text DineroText;
    void Update()
    {
        DineroText.text = "Dinero: " + ControladorDialogo.dinero.ToString(); 
    }
}
