using UnityEngine;
using System.Collections;
using GoogleMobileAds.Api;
using UnityEngine;
using UnityEngine.UI;

public class ReklamRewardedVideo : MonoBehaviour
{
    Button button;
    private RewardBasedVideoAd reklamObjesi;

    void Start()
    {
        button = GetComponent<Button>();
        MobileAds.Initialize(reklamDurumu => { });
        reklamObjesi = RewardBasedVideoAd.Instance;
    }
    // Ekranda test amaçlı "Reklamı Göster" butonu göstermeye yarar, bu fonksiyonu silerseniz buton yok olur
    public void RewardedVideo()
    {
      X2Boost();
      AdRequest reklamIstegi = new AdRequest.Builder().Build();
      reklamObjesi.LoadAd(reklamIstegi, "ca-app-pub-5801080710135130/6268285480");
      StartCoroutine(ReklamiGoster());        
    }
    void X2Boost()
    {
        Invoke("X2BoostStartEvent", 1);
        Invoke("X2BoostFinishEvent", 300);
    }
    void X2BoostStartEvent()
    {
        button.interactable = false;
        Time.timeScale = 2f;
    }
    void X2BoostFinishEvent()
    {
        button.interactable = true;
        Time.timeScale = 1f;
    }
    IEnumerator ReklamiGoster()
    {
        while (!reklamObjesi.IsLoaded())
            yield return null;

        reklamObjesi.Show();
    }
}