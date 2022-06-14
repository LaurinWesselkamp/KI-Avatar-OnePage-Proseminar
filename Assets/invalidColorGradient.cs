using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class invalidColorGradient : MonoBehaviour
{
    public GameObject leftController;
    public GameObject rigthController;
    private XRInteractorLineVisual leftRay;
    private XRInteractorLineVisual rigthtRay;

    // Start is called before the first frame update
    void Start()
    {

        leftRay = leftController.gameObject.GetComponent<XRInteractorLineVisual>();
        rigthtRay = rigthController.gameObject.GetComponent<XRInteractorLineVisual>();

        leftRay.enabled = false;
        rigthtRay.enabled = false;

    }

}
