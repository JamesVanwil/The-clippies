using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Timer : MonoBehaviour
{
        public float timer = 16f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer <= 0)
        {
             StartGame();
        }
        timer -= Time.deltaTime;
        
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
}
