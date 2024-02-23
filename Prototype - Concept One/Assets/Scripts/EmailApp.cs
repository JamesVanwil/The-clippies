using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmailApp : MonoBehaviour
{
    public GameObject SentEmailPage;
    public GameObject UrgentEmailPage;
    public GameObject SpamEmailPage;
    public GameObject BlockedEmailPage;

    public GameObject UrgentNotif;

    private void CloseAllEmailPages()
    {
        SentEmailPage.SetActive(false);
        UrgentEmailPage.SetActive(false);
        SpamEmailPage.SetActive(false);
        BlockedEmailPage.SetActive(false);
    }

    public void OpenSentEmailPage()
    {
        CloseAllEmailPages();
        SentEmailPage.SetActive(true);
    }

    public void OpenUrgentEmailPage()
    {
        CloseAllEmailPages();
        UrgentNotif.SetActive(false);
        UrgentEmailPage.SetActive(true);
    }

    public void OpenSpamEmailPage()
    {
        CloseAllEmailPages();
        SpamEmailPage.SetActive(true);
    }

    public void OpenBlockedEmailPage()
    {
        CloseAllEmailPages();
        BlockedEmailPage.SetActive(true);
    }
}
