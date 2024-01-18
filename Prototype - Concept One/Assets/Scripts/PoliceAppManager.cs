using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class PoliceAppManager : MonoBehaviour
{
    public TMP_InputField answerInputField;
    public TextMeshProUGUI playerInputDisplay;
    public GameObject correctImage;
    public GameObject wrongImage;
    public GameObject gameOverImage;

    private int wrongAttempts = 0;
    private bool isTimerRunning = false;
    private float timer = 60f;

    private const int maxCharacterLimit = 20; // Set your desired character limit here

    private void Start()
    {
        // Initialize your UI elements as needed
        correctImage.gameObject.SetActive(false);
        wrongImage.gameObject.SetActive(false);
        gameOverImage.gameObject.SetActive(false);

        // Set the initial text of the playerInputDisplay to an empty string
        playerInputDisplay.text = "";

        // Set character limit for the input field
        answerInputField.characterLimit = maxCharacterLimit;
    }

    private void Update()
    {
        // Check if the timer is running
        if (isTimerRunning)
        {
            // Update the timer
            timer -= Time.deltaTime;

            // Check if time is up
            if (timer <= 0f)
            {
                // Time is up, handle the wrong attempt
                HandleWrongAttempt();

                // Start a coroutine to clear player input text after a delay
                StartCoroutine(ClearPlayerInputTextAfterDelay());
            }
        }

        // Check for key press (Enter) to confirm answer, but only if the input field is interactable
        if (answerInputField.interactable && Input.GetKeyDown(KeyCode.Return))
        {
            CheckAnswer();
        }

        // Hide correct image and wrong image when the timer reaches zero
        if (timer <= 0f)
        {

            wrongImage.gameObject.SetActive(false);   // Hide wrong image
        }
    }

    private IEnumerator ClearPlayerInputTextAfterDelay()
    {
        // Wait for a short delay (you can adjust the time as needed)
        yield return new WaitForSeconds(1f);

        // Clear player input text
        playerInputDisplay.text = "";
    }





    public void CheckAnswer()
    {
        // Compare the input text with the correct answer (replace "CorrectAnswer" with your actual answer)
        string correctAnswer = "CorrectAnswer";
        if (answerInputField.text.ToLower() == correctAnswer.ToLower())
        {
            // Player provided the correct answer
            HandleCorrectAnswer();
        }
        else
        {
            // Player provided the wrong answer
            HandleWrongAttempt();
        }

        // Display the player's input in the UI Text element
        playerInputDisplay.text = answerInputField.text;

        // Clear the input field for the next attempt
        answerInputField.text = "";
    }


    private void HandleCorrectAnswer()
    {
        // Stop the timer
        isTimerRunning = false;

        // Display the correct image
        correctImage.gameObject.SetActive(true);

        // You can perform additional actions here if needed
    }

    private void HandleWrongAttempt()
    {
        // Increment wrong attempts
        wrongAttempts++;

        // Check if the player has exceeded the allowed attempts
        if (wrongAttempts >= 3)
        {
            // Disable the input field permanently and display the game over image
            answerInputField.interactable = false;
            gameOverImage.gameObject.SetActive(true);
            StartCoroutine(DelayBeforeMainMenu());
            wrongImage.gameObject.SetActive(false); // Hide the wrong image

            // You might want to perform additional actions here for the game over state
        }
        else
        {
            // Disable the input field immediately after a wrong attempt and display the wrong image
            answerInputField.interactable = false;
            wrongImage.gameObject.SetActive(true);
           
            // Start a coroutine to re-enable the input field after a delay
            StartCoroutine(EnableInputFieldAfterDelay());
        }
    }

    private IEnumerator EnableInputFieldAfterDelay()
    {
        // Wait for 60 seconds (adjust the time as needed)
        yield return new WaitForSeconds(60f);

        // Enable the input field again
        answerInputField.interactable = true;

        // Reset the timer
        timer = 60f;

        // Hide the wrong image
        wrongImage.gameObject.SetActive(false);
    }

    public void StartTimer()
    {
        // Start the timer when the player begins typing
        isTimerRunning = true;
    }

    IEnumerator DelayBeforeMainMenu()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(0);
    }

}