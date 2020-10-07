using UnityEngine;
using System.Collections;
using GoogleMobileAds.Api;
public class ReklamInterstitial : MonoBehaviour
{
    private InterstitialAd reklamObjesi;

    void Start()
    {
        MobileAds.Initialize(reklamDurumu => { });
    }
    public void reklam()
    {
        if(Healthbar.GunLvlCounter%3==0)
        {
        if (reklamObjesi != null)
        reklamObjesi.Destroy();
        reklamObjesi = new InterstitialAd("ca-app-pub-4820411076035062/1381416198");
        AdRequest reklamIstegi = new AdRequest.Builder().Build();
        reklamObjesi.LoadAd(reklamIstegi);
        StartCoroutine(ReklamiGoster());
        }
    }
    IEnumerator ReklamiGoster()
    {
        while (!reklamObjesi.IsLoaded())
            yield return null;

        reklamObjesi.Show();
    }
    void OnDestroy()
    {
        if (reklamObjesi != null)
            reklamObjesi.Destroy();
    }
}