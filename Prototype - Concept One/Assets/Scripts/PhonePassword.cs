using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using System.Collections;
public class PhonePassword : MonoBehaviour
{
    [SerializeField] private TMP_Text inputText; // Reference to the TMP_Text displaying input
    [SerializeField] private TMP_Text wrongPasswordText; // Reference to the TMP_Text displaying wrong password message

    private bool inputEnabled = false;
    private string password = "5861";
    private string currentInput = "";

    void Start()
    {
        // Reset the password state when the game starts
        ResetPasswordState();
    }

    void Update()
    {
        if (inputEnabled && Input.GetKeyDown(KeyCode.Return))
        {
            CheckPassword();
        }
    }

    public void EnableInput()
    {
        inputEnabled = true;
    }

    public void DisableInput()
    {
        inputEnabled = false;
    }

    public void AddDigit(int digit)
    {
        if (currentInput.Length < 4) // Limit input to 4 characters
        {
            currentInput += digit.ToString();
            inputText.text = currentInput;
        }
    }

    public void ClearInput()
    {
        currentInput = "";
        inputText.text = currentInput;
    }

    public void CheckPassword()
    {
        if (currentInput == password)
        {
            OpenPhone();
        }
        else
        {
            ShowWrongPasswordText();
            ClearInput();
            StartCoroutine(HideWrongPasswordText());
        }
    }

    private void OpenPhone()
    {
        SceneManager.LoadScene(2); // Load Scene 2 (Phone scene)
    }

    public void LeavePhone()
    {
        SceneManager.LoadScene(1); // Load Scene 2 (Phone scene)
    }

    private void ResetPasswordState()
    {
        // Clear the saved password state
        PlayerPrefs.DeleteKey("PasswordEntered");
        PlayerPrefs.Save();
    }

    private void ShowWrongPasswordText()
    {
        wrongPasswordText.gameObject.SetActive(true);
    }

    private IEnumerator HideWrongPasswordText()
    {
        yield return new WaitForSeconds(5f);
        wrongPasswordText.gameObject.SetActive(false);
    }
}
