
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Responding : MonoBehaviour
{
    private Animator animator;
    public GameObject _einleitungCanva;
    public GameObject _brainstormingCanva;
    public GameObject _startOnePageCanva;
    public GameObject _endCanva;
    public GameObject _explain2Canva;
    public GameObject _talkCanva;
    public GameObject _onePage;
    public GameObject _ideenAll;
    public GameObject _timer;
    public GameObject _ausgabeFenster;
    public bool schonErklaert = false;
    public bool onePageGestartet = false;

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
        CanvaNoOverlapping();
        _brainstormingCanva.SetActive(true);
    }

    public void StartOnePage(string[] values)
    {
        print("StartOnePage wurde aufgerufen");
        CanvaNoOverlapping();

        _startOnePageCanva.SetActive(true);
        _onePage.SetActive(true);
        _timer.SetActive(true);
        _ausgabeFenster.SetActive(true);

        onePageGestartet = true;
        
    }

    public void StopOnePage(string[] values)
    {
        print("StopOnePage wurde aufgerufen");
        CanvaNoOverlapping();

        _onePage.SetActive(false);
        _startOnePageCanva.SetActive(false);
        _timer.SetActive(false);

        _endCanva.SetActive(true);
        _ideenAll.SetActive(true);
    }

    public void ReactThanks(string[] values)
    {
        print("ReactThanks wurde aufgerufen");
        animator.SetTrigger("Thanked");
    }

    public void Explanation2(string[] values)
    {
        print("Explanation2 wurde aufgerufeen");
        CanvaNoOverlapping();
        
        if(schonErklaert == false)
        {
            _explain2Canva.SetActive(true);
            schonErklaert = true;
        }
        else
        {
            StimulusForDiscussion();
        }

    }

    public void StimulusForDiscussion()
    {
        _talkCanva.SetActive(true);

        schonErklaert = false;
    }



    //Hilfsmethode, damit sich keine zwei Canvas überlappen
    public void CanvaNoOverlapping()
    {
        _einleitungCanva.SetActive(false);
        _brainstormingCanva.SetActive(false);
        _startOnePageCanva.SetActive(false);
        _endCanva.SetActive(false);
        _explain2Canva.SetActive(false);
        _talkCanva.SetActive(false);
        _onePage.SetActive(false);
        _timer.SetActive(false);
        _ausgabeFenster.SetActive(false);

        if (onePageGestartet == true)
        {
            _onePage.SetActive(true);
            _timer.SetActive(true);
            _ausgabeFenster.SetActive(true);
        }
    }
}

