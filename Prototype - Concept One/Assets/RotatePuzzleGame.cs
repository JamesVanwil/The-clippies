using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RotatePuzzleGame : MonoBehaviour
{
    public float zOne = 0;
    public float zTwo = 0;
    public float zThird = 0;
    public GameObject signalLow;
    public GameObject signalNormal;
    public GameObject signalHigh;

    public GameObject enableLFoxMini;
    public GameObject enableLFoxMaxi;
    public GameObject disableNoAccesLFoxMini;
    public GameObject disableNoAccesLFoxMaxi;

    void Start()
    {
        zOne = signalLow.transform.rotation.z;
        zTwo = signalNormal.transform.rotation.z;
        zThird = signalHigh.transform.rotation.z;
        OnPointerClickLow();
        OnPointerClickNormal();
        OnPointerClickHigh();
    }

    public void OnPointerClickLow()
    {
        zOne += 45.00000f;
        signalLow.transform.rotation = Quaternion.Euler(0f,0f, zOne);

        wifiFixedCheck();
    }

    public void OnPointerClickNormal()
    {
        zOne += 15.00000f;
        signalLow.transform.rotation = Quaternion.Euler(0f, 0f, zOne);

        zTwo += 45.00000f;
        signalNormal.transform.rotation = Quaternion.Euler(0f, 0f, zTwo);

        wifiFixedCheck();
    }

    public void OnPointerClickHigh()
    {
        zTwo += 45.00000f;
        signalNormal.transform.rotation = Quaternion.Euler(0f, 0f, zTwo);

        zThird += 25.00000f;
        signalHigh.transform.rotation = Quaternion.Euler(0f, 0f, zThird);

        wifiFixedCheck();
    }

    private void wifiFixedCheck()
    {
        zOne = (int)zOne;
        zTwo = (int)zTwo;
        zThird = (int)zThird;

        zOne %= 360;
        zTwo %= 360;
        zThird %= 360;

        if (zOne == 0 && zTwo == 0 && zThird == 0)
        {   
            enableLFoxMini.SetActive(true);
            enableLFoxMaxi.SetActive(true);
            disableNoAccesLFoxMini.SetActive(false);
            disableNoAccesLFoxMaxi.SetActive(false);
        }

        Debug.Log("gfgfdgfggfgdf: " + zOne + " " + " " + zTwo + " " + zThird);
    }
}
