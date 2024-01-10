using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BatteryPhone : MonoBehaviour
{
    public TMP_Text batteryText; // Attach a UI Text to this variable in the Unity Editor
    public float startingBattery = 100f; // Starting battery percentage
    public float decreaseRate = 1f; // Battery decrease rate per second

    void Start()
    {
        // Set the initial battery level
        UpdateBatteryText();

        // Invoke the DecreaseBattery method every second
        InvokeRepeating("DecreaseBattery", 0f, 10f);
    }

    void DecreaseBattery()
    {
        // Decrease the battery level based on the decrease rate
        startingBattery -= decreaseRate;

        // Clamp the battery level to be within the range of 0 to 100
        startingBattery = Mathf.Clamp(startingBattery, 0f, 100f);

        // Update the UI Text with the new battery level
        UpdateBatteryText();

        // Check if the battery is completely drained
        if (startingBattery <= 0f)
        {
            Debug.Log("Battery is empty!");
            // You might want to perform additional actions here, e.g., game over, alert, etc.
        }
    }

    void UpdateBatteryText()
    {
        // Update the UI Text with the current battery level
        batteryText.text = $" {Mathf.Round(startingBattery)}%";
    }
}
