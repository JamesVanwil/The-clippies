using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AppManager : MonoBehaviour
{
    public Image openedAppImage;
    public GameObject homeButton;

    public Image secondOpenedAppImage;
    public GameObject secondHomeButton;


    public Image thirdOpenedAppImage;
    public GameObject thirdHomeButton;

    private void Start()
    {
        openedAppImage.enabled = false;
        homeButton.SetActive(false);

        secondOpenedAppImage.enabled = false;
        secondHomeButton.SetActive(false);

        thirdOpenedAppImage.enabled = false;
        thirdHomeButton.SetActive(false);

    }

    public void Openapp1()
    {
        openedAppImage.enabled = true;
        homeButton.SetActive(true);
    }

    public void Closeapp1()
    {
        openedAppImage.enabled = false;
        homeButton.SetActive(false);
    }

    public void Openapp2()
    {
        secondOpenedAppImage.enabled = true;
        secondHomeButton.SetActive(true);
    }

    public void Closeapp2()
    {
        secondOpenedAppImage.enabled = false;
        secondHomeButton.SetActive(false);
    }

    public void Openapp3()
    {
        thirdOpenedAppImage.enabled = true;
        thirdHomeButton.SetActive(true);
    }

    public void Closeapp3()
    {
        thirdOpenedAppImage.enabled = false;
        thirdHomeButton.SetActive(false);
    }
}
