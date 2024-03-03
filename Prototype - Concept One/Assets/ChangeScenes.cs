using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScenes : MonoBehaviour
{
    private bool canChangeScene = false;
    public int timer = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player enter zone");
            canChangeScene = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player exit zone");
            canChangeScene = false;
        }
    }

    private void Update()
    {
        if (canChangeScene && Input.GetKeyDown(KeyCode.E))
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            this.timer = PlayerBehavior.timers;
            HintTimer.timer = this.timer;
            SceneManager.LoadScene(1);
            HintTimer.timer = this.timer;
        }
    }
    public void GoToHintScene()
    {
        this.timer = HintTimer.timer;
        PlayerBehavior.timers = this.timer;
        SceneManager.LoadScene(4);
        PlayerBehavior.timers = this.timer;
    }
}
