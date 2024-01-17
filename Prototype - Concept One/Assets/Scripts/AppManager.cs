using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AppManager : MonoBehaviour
{

    [Header("SMS")]

    public GameObject openedAppImage;
    public GameObject homeButton;
    public GameObject TextsPage;
    public GameObject CallsPage;

    [Header("Instagram")]

    public GameObject secondOpenedAppImage;
    public GameObject secondHomeButton;
    public GameObject FeedPage;
    public GameObject ProfilePage;
    public GameObject PostOneOnFeedComments;


    
    private bool isPostCommentsActive = false;

    [Header("Snapchat")]

    public GameObject thirdOpenedAppImage;
    public GameObject thirdHomeButton;
    public GameObject SnapProfile;
    public GameObject SnapChats;
    public GameObject SnapMemories;

    public GameObject DateTimePost1;

    [Header("112")]

    public GameObject PoliceApp;



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

        FeedPage.SetActive(false);
        ProfilePage.SetActive(false);

        PostOneOnFeedComments.SetActive(false);

        SnapProfile.SetActive(false);
        SnapChats.SetActive(false);
        SnapMemories.SetActive(false);

        DateTimePost1.SetActive(false);
    

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
        FeedPage.SetActive(true);
    }

    public void Closeapp2()
    {
        secondOpenedAppImage.SetActive(false);
        secondHomeButton.SetActive(false);
        FeedPage.SetActive(false);
        ProfilePage.SetActive(false);
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
        SnapProfile.SetActive(false);
        SnapChats.SetActive(false);
        SnapMemories.SetActive(false);
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

    public void OpenFeedPage()
    {
        FeedPage.SetActive(true);
        ProfilePage.SetActive(false);
    }

    public void OpenProfilePage()
    {
        FeedPage.SetActive(false);
        ProfilePage.SetActive(true);
    }

    public void ShowPostOneComments()
    {
        isPostCommentsActive = !isPostCommentsActive;

        
        PostOneOnFeedComments.SetActive(isPostCommentsActive);
    }

    public void OpenSnapProfile()
    {
        SnapChats.SetActive(false);
        SnapProfile.SetActive(true);
        SnapMemories.SetActive(false);

    }

    public void OpenSnapChats()
    {
        SnapChats.SetActive(true);
        SnapProfile.SetActive(false);
        SnapMemories.SetActive(false);
    }

    public void OpenSnapMemories()
    {
        SnapChats.SetActive(false);
        SnapProfile.SetActive(false);
        SnapMemories.SetActive(true);
    }

    public void MemoriesCommentPhoto1()
    {
        isPostCommentsActive = !isPostCommentsActive;
        DateTimePost1.SetActive(isPostCommentsActive);
    }

    public void Open112App()
    {
        PoliceApp.SetActive(true);
    }

    public void Close112App()
    {
        PoliceApp.SetActive(false);
    }




}
