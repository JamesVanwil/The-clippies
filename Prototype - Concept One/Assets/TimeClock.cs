using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;

public class TimeClock : MonoBehaviour
{
    public TMP_Text clockText;

    void Start()
    {
        // Invoke the UpdateClock method every second
        InvokeRepeating("UpdateClock", 0f, 1f);
    }

    void UpdateClock()
    {
        // Get the current time
        DateTime currentTime = DateTime.Now;

        // Format the time as a string
        string timeString = currentTime.ToString("HH:mm");

        // Update the UI text with the current time
        clockText.text = timeString;
    }
}
