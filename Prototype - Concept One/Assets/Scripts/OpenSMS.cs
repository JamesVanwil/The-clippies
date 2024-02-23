using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenSMS : MonoBehaviour
{
    public GameObject MaxConvo;
    public GameObject PhilConvo;
    public GameObject SophiaConvo;
    public GameObject AnonymousConvo;
    // Start is called before the first frame update
    void Start()
    {
        MaxConvo.SetActive(false);
        PhilConvo.SetActive(false);
        SophiaConvo.SetActive(false);
        AnonymousConvo.SetActive(false);
    }

    public void MaxConvoOpen()
    {
        MaxConvo.SetActive(true);
    }

    public void PhilConvoOpen()
    {
        PhilConvo.SetActive(true);
    }

    public void SophiaConvoOpen()
    {
        SophiaConvo.SetActive(true);
    }

    public void AnonymousConvoOpen()
    {
        AnonymousConvo.SetActive(true);
    }

    public void MaxConvoClose()
    {
        MaxConvo.SetActive(false);
    }

    public void PhilConvoClose()
    {
        PhilConvo.SetActive(false);
    }

    public void SophiaConvoClose()
    {
        SophiaConvo.SetActive(false);
    }

    public void AnonymousConvoClose()
    {
        AnonymousConvo.SetActive(false);
    }





}
