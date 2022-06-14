using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Responding : MonoBehaviour
{
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ReactGreet(string[] values)
    {
        //for (int i = 0; i < values.Length; i++) 
        //{ 
        //print(values[i]);
        //}
        print("ReactGreet wurde aufgerufen");
        animator.SetTrigger("IsGreeted");
    }
    public void StartIntro(string[] values)
    {
        print("StartIntro wurde aufgerufen");
        //play introduction text
    }

    public void StartOnePage(string[] values)
    {
        print("StartOnePage wurde aufgerufen");
        //allow writing
    }

    public void StopOnePage(string[] values)
    {
        print("StopOnePage wurde aufgerufen");
        //disallow writing
    }

    public void ReactThanks(string[] values)
    {
        print("ReactThanks wurde aufgerufen");
        animator.SetTrigger("Thanked");
    }
}

