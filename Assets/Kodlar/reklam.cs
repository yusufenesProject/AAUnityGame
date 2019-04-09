using GoogleMobileAds.Api;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reklam : MonoBehaviour
{
    InterstitialAd interstitial;
    // Use this for initialization
    void Start()
    {
        //1. asama
        #if UNITY_ANDROID
                string appId = "ca - app - pub - 6098380623362549~9344552539";
        #elif UNITY_IPHONE
                    string appId = "ca-app-pub-3940256099942544~1458002511";
        #else
                    string appId = "unexpected_platform";
        #endif

        // Initialize the Google Mobile Ads SDK.
        MobileAds.Initialize(appId);

        //2. asama
        #if UNITY_ANDROID
                string adUnitId = "ca-app-pub-3940256099942544/1033173712";
        #elif UNITY_IPHONE
                string adUnitId = "ca-app-pub-3940256099942544/4411468910";
        #else
                string adUnitId = "unexpected_platform";
        #endif

        // Initialize an InterstitialAd.
        interstitial = new InterstitialAd(adUnitId);

        //3. asama
        AdRequest request = new AdRequest.Builder().AddTestDevice("2077ef9a63d2b398840261c8221a0c9b").Build();
        interstitial.LoadAd(request);

        //4. asama

    }

    // Update is called once per frame
    void Update()
    {
        if (interstitial.IsLoaded())
        {
            interstitial.Show();
        }
    }
}
