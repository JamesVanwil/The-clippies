using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;



public class TextBehaviour : MonoBehaviour
{
    public TMP_Text introductionText;
    public TMP_Text mainText;
    public TMP_Text pointsT;
    public TMP_Text timerT;

    private bool delayFinished = false;
    private float delayTimer = 0f;
    private float delayDuration = 10f;


    public int randomNumber = 0;
    public int points = 0;

    
    public float timeLeft = 10f;

    public string[] emailList; //{"0", "noreply@dhlparcel.nl", "2", "3", "4", "5", "6", "7", "8", "9", };
    public int[] rightOrWrong; //{1, 1, 1, 1, 1, 1, 1, 1, 1, 1};

        
    // Start is called before the first frame update
    void Start()
    {
        emailList = new string[]{ "Defenitlynotavirus@completelysafe.com", "youwon@freemoney.com", "ngoctrinh1403@gmail.com", "customerservice@amazonhelp.ru",
            "Donotreply@mywebshop.com", "customerservice@amazon.com", "automail@bol.com", "noreply@steampowered.com", "info@megekko.nl", "noreply@dhlparcel.nl", };
        rightOrWrong = new int[] { 0, 0, 0, 0, 1, 1, 1, 1, 1, 1 };
        //emailList[0] = "";
        //emailList[1] = "noreply@dhlparcel.nl";
        //emailList[2] = "2";
        //emailList[3] = "3";
        //emailList[4] = "4";
        //emailList[5] = "5";
        //emailList[6] = "6";
        //emailList[7] = "7";
        //emailList[8] = "8";
        //emailList[9] = "9";


        //rightOrWrong[0] = 1;
        //rightOrWrong[1] = 1;
        //rightOrWrong[2] = 1;
        //rightOrWrong[3] = 1;
        //rightOrWrong[4] = 1;
        //rightOrWrong[5] = 1;
        //rightOrWrong[6] = 1;
        //rightOrWrong[7] = 1;
        //rightOrWrong[8] = 1;
        //rightOrWrong[9] = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (!delayFinished)
        {
            delayTimer += Time.deltaTime;
            if (delayTimer >= delayDuration)
            {
                delayFinished = true;
                introductionText.enabled = false;
            }
            else
            {
                return; // Skip the rest of the Update() method until delay is finished
            }
        }

        if (timeLeft > 0f)
        {
            timeLeft -= Time.deltaTime;
        }
        else if (timeLeft == 0f)
        {
            Debug.Log("U lose");
            SceneManager.LoadScene(3);
        }
        else if (timeLeft < 0f)
        {
            timeLeft = 0f;
        }

        timerT.text = $"{Mathf.Round(timeLeft)}";
    }
    public void ChangeText(int choice)
    {
        if (choice == rightOrWrong[randomNumber]) // if right choice
        {
            points++;
            timeLeft += 2f; //1f

            if (points >= 10)
            {
                //unlock hint
               
            }
        }
        else        // if wrong choice
        {
            timeLeft -= 1f; // 0.5f
            points = Mathf.Max(0, points - 1); // Ensure points don't go below 0
        }
        randomNumber = Random.Range(0, 10);
        pointsT.text = $"{points}/10";
        mainText.text = emailList[randomNumber];

        if(points >= 10)
        {
            HintTimer.timer += 500;
            points = 0;
            SceneManager.LoadScene(1);
        }
    }

}

