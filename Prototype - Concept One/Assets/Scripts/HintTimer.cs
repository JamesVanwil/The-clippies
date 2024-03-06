using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintTimer : MonoBehaviour
{
    [SerializeField]
    private int hintTimerFirst = 0;

    [SerializeField]
    private int hintTimerSecond = 0;

    [SerializeField]
    private int hintTimerThird = 0;

    [SerializeField]
    private int hintTimerFourth = 0;

    public static int timer = 0;

    [SerializeField]
    private GameObject hintOneNote;

    [SerializeField]
    private GameObject hintSecondNote;

    [SerializeField]
    private GameObject hintThirdNote;

    [SerializeField]
    private GameObject hintFourthNote;

    private int minigameAddedWaitingTime = 0;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //++timer;

        if(timer >= hintTimerFirst + minigameAddedWaitingTime && !hintOneNote.active)
        {
            hintOneNote.SetActive(true);
        }

        if (timer >= hintTimerSecond + minigameAddedWaitingTime && !hintSecondNote.active)
        {
            hintSecondNote.SetActive(true);
        }

        if (timer >= hintTimerThird + minigameAddedWaitingTime && !hintThirdNote.active)
        {
            hintThirdNote.SetActive(true);
        }

        if (timer >= hintTimerFourth + minigameAddedWaitingTime && !hintFourthNote.active)
        {
            hintFourthNote.SetActive(true);
        }
    }
}
