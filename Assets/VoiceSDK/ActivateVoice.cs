using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Facebook.WitAi;
using UnityEngine.InputSystem;

public class ActivateVoice : MonoBehaviour
{
    [SerializeField]
    private Wit wit;

    private void Start()
    {
        if (wit == null) wit = GetComponent<Wit>();
    }

    private void Update()
    {
        if(OVRInput.GetDown(OVRInput.Button.One))
        {
            print("Button A wurde gedrückt!");
            WitActivate();
        }
    }

    public void WitActivate()
    {
        wit.Activate();
    }
}
