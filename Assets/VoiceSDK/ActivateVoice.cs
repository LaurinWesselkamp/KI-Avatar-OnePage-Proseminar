using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Facebook.WitAi;
using UnityEngine.InputSystem;
using Oculus.Voice;

public class ActivateVoice : MonoBehaviour
{
    public AudioClip click;

    [SerializeField] private AppVoiceExperience voiceExperience;

    private void OnValidate()
    {
        if (!voiceExperience) voiceExperience = GetComponent<AppVoiceExperience>();
    }

    private void Start()
    {
       voiceExperience = GetComponent<AppVoiceExperience>();
    }

    private void Update()
    {
        if(OVRInput.GetDown(OVRInput.Button.One))
        {
            print("Button A wurde gedrückt!");
            AudioSource.PlayClipAtPoint(click, transform.position);
            WitActivate();
        }
    }

    public void WitActivate()
    {
        voiceExperience.Activate();
    }
}
