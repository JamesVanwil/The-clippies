using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AppManager : MonoBehaviour
{
    public GameObject openedAppImage;
    public GameObject homeButton;
    public GameObject TextsPage;
    public GameObject CallsPage;

    public GameObject secondOpenedAppImage;
    public GameObject secondHomeButton;


    public GameObject thirdOpenedAppImage;
    public GameObject thirdHomeButton;

    private void Start()
    {
        openedAppImage.SetActive(false);
        homeButton.SetActive(false);

        secondOpenedAppImage.SetActive(false);
        secondHomeButton.SetActive(false);

        thirdOpenedAppImage.SetActive(false);
        thirdHomeButton.SetActive(false);

        TextsPage.SetActive(false);
        CallsPage.SetActive(false);
    

       }

    public void Openapp1()
    {
        openedAppImage.SetActive(true);
        homeButton.SetActive(true);
        TextsPage.SetActive(true);

    }

    public void Closeapp1()
    {
        openedAppImage.SetActive(false);
        homeButton.SetActive(false);
        TextsPage.SetActive(false);
        CallsPage.SetActive(false);
    }

    public void Openapp2()
    {
        secondOpenedAppImage.SetActive(true);
        secondHomeButton.SetActive(true);
    }

    public void Closeapp2()
    {
        secondOpenedAppImage.SetActive(false);
        secondHomeButton.SetActive(false);
    }

    public void Openapp3()   
    {
        thirdOpenedAppImage.SetActive(true);
        thirdHomeButton.SetActive(true);
    }

    public void Closeapp3()
    {
        thirdOpenedAppImage.SetActive(false);
        thirdHomeButton.SetActive(false);
    }

    public void OpenTextPage()
    {
        TextsPage.SetActive(true);
        CallsPage.SetActive(false);
    }

    public void OpenCallsPage()
    {
        TextsPage.SetActive(false);
        CallsPage.SetActive(true);
    }
}
