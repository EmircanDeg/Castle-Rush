using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.UI;

public class reklamlar : MonoBehaviour, IUnityAdsListener
{
    string gameId = "3921015";
    bool testMode = false;
    string interstetialId = "video";
    string myPlacementId = "rewardedVideo";
    bool butonbasildi = false;
    bool skip = false;
    public GameObject player;
    public GameObject reklamparasi;
    public GameObject reklamparasitext;

    void Start()
    {
        Advertisement.Initialize(gameId, testMode);
        Advertisement.AddListener(this);
    }

    // Update is called once per frame
    public void ShowInterstitialAd()
    {
        // Check if UnityAds ready before calling Show method:
        if (Advertisement.IsReady(interstetialId))
        {
            Advertisement.Show(interstetialId);
        }

    }

    public void ShowRewardedVideo()
    {
        // Check if UnityAds ready before calling Show method:
        if (Advertisement.IsReady(myPlacementId))
        {
            Advertisement.Show(myPlacementId);
            butonbasildi = true;
        }
        else
        {
            Debug.Log("Rewarded video is not ready at the moment! Please try again later!");
        }
    }

    public void ShowRewardedVideoskip()
    {
        // Check if UnityAds ready before calling Show method:
        if (Advertisement.IsReady(myPlacementId))
        {
            Advertisement.Show(myPlacementId);
            skip = true;
        }
        else
        {
            Debug.Log("Rewarded video is not ready at the moment! Please try again later!");
        }
    }
    public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    {
        // Define conditional logic for each ad completion status:
        if (showResult == ShowResult.Finished)
        {
            if (butonbasildi == true)
            {
                PlayerPrefs.SetInt("para", PlayerPrefs.GetInt("para") + player.GetComponent<playerhareket>().kazanilanpara);
                reklamparasi.SetActive(true);
                reklamparasitext.GetComponent<Text>().text = player.GetComponent<playerhareket>().kazanilanpara.ToString();
                butonbasildi = false;
            }
            if (skip == true) { }

        }
        else if (showResult == ShowResult.Skipped)
        {
            butonbasildi = false;
        }
        else if (showResult == ShowResult.Failed)
        {
            butonbasildi = false;
        }
    }


    public void OnUnityAdsDidError(string message)
    {
        throw new System.NotImplementedException();
    }

    /*public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    {
        throw new System.NotImplementedException();
    }
    */
    public void OnUnityAdsDidStart(string placementId)
    {
        throw new System.NotImplementedException();
    }

    public void OnUnityAdsReady(string placementId)
    {
        throw new System.NotImplementedException();
    }

   
}
