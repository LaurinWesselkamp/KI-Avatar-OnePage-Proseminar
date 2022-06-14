using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

/*
 * Dies ist eine selbst erstellte Klasse um den Text aus dem InputField in die Tabelle zu importieren.
 * 
 * @author Laurin Wesselkamp
 * @version 01.06.2022
 */

public class SetNameOnScreen : MonoBehaviour
{
    public TextMeshProUGUI _kommentar;
    public TMP_InputField _kommentarInputField;
    private bool _firstSet = false; 

    public void setKommentar()
    {
        if(_firstSet == true)
        {
            _kommentar.text = _kommentar.text + "\n------------------------------------------------------------------------" + _kommentarInputField.text;
            _kommentarInputField.text = "";
            return;
        }
    
        _kommentar.text = _kommentarInputField.text;
        _kommentarInputField.text = "";
        _firstSet = true;
    }
}
