using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;
using GoogleMobileAds.Api;
public class GameManager : MonoBehaviour
{	

    public GameObject winText;
    private InterstitialAd interstitial;
    public GameObject LoseText;
    public GameObject newrecord;
    [SerializeField] Text RecordTime;
    public GameObject restartButton;
   
    int score=0;
    float currentTime=0f;
    float startingTime=10f;
    [SerializeField] Text CountdownText;
    public GameObject[] Stars;


    
    void Start()
{
   #if UNITY_ANDROID
    string appId = "ca-app-pub-5999227573021666~3489179178";
    #endif
    MobileAds.Initialize(appId);
        currentTime=startingTime;
         Time.timeScale=1;
         RecordTime.text = PlayerPrefs.GetFloat("RecordTime",0).ToString("0.00");
    
     
    }

    // Update is called once per frame
    void Update()
    {    if(Input.GetKeyDown (KeyCode.Escape))
    SceneManager.LoadScene("Menu");
        currentTime-=1*Time.deltaTime;
        CountdownText.text=currentTime.ToString("0");
     
    if(currentTime <=0)
    {
        currentTime=0;
        Lose();
    }




    }


    public void ScoreUp()
    {
        score++;
        if(score>=5)
        {
            Win();
            StarsAchieved();
        }
    }
  void Lose()
    {
LoseText.SetActive(true);
restartButton.SetActive(true);

Time.timeScale=0;
    }
    void Win()
    {
winText.SetActive(true);
restartButton.SetActive(true);

Time.timeScale=0;
  if(currentTime > PlayerPrefs.GetFloat("RecordTime",0))
       {
           PlayerPrefs.SetFloat("RecordTime", currentTime);
           RecordTime.text = currentTime.ToString("0.00");
         
            newrecord.SetActive(true);
       }

    }
public void Restart()
{
    ShowInterstitial();
    SceneManager.LoadScene("Menu");
}
public void StarsAchieved()
{  
   if(currentTime>0 && currentTime<=2) 
{
    Stars[0].SetActive(true);

}
else if(currentTime>2 && currentTime<=4)
{
    Stars[0].SetActive(true);
    Stars[1].SetActive(true);
   
}

else{
     Stars[0].SetActive(true);
     Stars[1].SetActive(true);
     Stars[2].SetActive(true);



   }


}
public void ShowInterstitial()
{
    RequestInterstitial();
}
private void RequestInterstitial()
{
     #if UNITY_ANDROID
    string interstitialId = "ca-app-pub-3940256099942544/1033173712";
    #endif

    if(interstitial != null)
    interstitial.Destroy();
    interstitial = new InterstitialAd(interstitialId);
    interstitial.OnAdLoaded +=HandleOnAdLoaded;
    interstitial.LoadAd(CreateNewRequest());
}
public void HandleOnAdLoaded(object sender, EventArgs args)
{
    if(interstitial.IsLoaded())
   interstitial.Show();
}

private AdRequest CreateNewRequest()
{
    return new AdRequest.Builder().Build();
}
}
