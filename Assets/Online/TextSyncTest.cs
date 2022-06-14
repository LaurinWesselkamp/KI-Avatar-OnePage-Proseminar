using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextSyncTest : MonoBehaviour
{
    public TextMeshProUGUI _kommentar;
    public TextMeshProUGUI _previousKommentar;

    private TextSync _textSync;

    private void Awake()
    {
        //Get a reference to the text sync component
        _textSync = GetComponent<TextSync>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_kommentar.text != _previousKommentar.text)
        {
            _textSync.SetText(_kommentar.text);
            _previousKommentar.text = _kommentar.text;
        }
    }

}
