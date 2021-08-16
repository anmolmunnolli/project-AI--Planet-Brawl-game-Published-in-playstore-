/*using UnityEngine;
using admob;
public class admobdemo : MonoBehaviour {
	Admob ad;
	string appID="";
	string bannerID="";
	string interstitialID="";
	string videoID="";
	string nativeBannerID = "";
	
	void Start () {
        Debug.Log("start unity demo-------------");
         initAdmob();
	}
	
	void Update () {
	    if (Input.GetKeyUp (KeyCode.Escape)) {
            Debug.Log(KeyCode.Escape+"-----------------");
	    }
    }
   
    void initAdmob()
    {

				
#if UNITY_ANDROID
        		 appID="ca-app-pub-3940256099942544~3347511713";
				
				 interstitialID="ca-app-pub-3940256099942544/1033173712";
				
#endif
        AdProperties adProperties = new AdProperties();
        adProperties.isTesting = true;

        ad = Admob.Instance();
            ad.bannerEventHandler += onBannerEvent;
            ad.interstitialEventHandler += onInterstitialEvent;
            ad.rewardedVideoEventHandler += onRewardedVideoEvent;
            ad.nativeBannerEventHandler += onNativeBannerEvent;
            ad.initSDK(appID,adProperties);//reqired,adProperties can been null
    }
	void OnGUI(){
        if (GUI.Button(new Rect(120, 0, 100, 60), "showInterstitial"))
        {
           Debug.Log("touch inst button -------------");
            if (ad.isInterstitialReady())
            {
                ad.showInterstitial();
            }
            else
            {
                ad.loadInterstitial(interstitialID);
            }
        }
        if (GUI.Button(new Rect(240, 0, 100, 60), "showRewardVideo"))
        {
            Debug.Log("touch video button -------------");
            if (ad.isRewardedVideoReady())
            {
                ad.showRewardedVideo();
            }
            else
            {
            	ad.loadRewardedVideo(videoID);
            }
        }
        if (GUI.Button(new Rect(0, 100, 100, 60), "showbanner"))
        {
            Admob.Instance().showBannerRelative(bannerID,AdSize.SMART_BANNER, AdPosition.BOTTOM_CENTER);
        }
        if (GUI.Button(new Rect(120, 100, 100, 60), "showbannerABS"))
        {
            Admob.Instance().showBannerAbsolute(bannerID,AdSize.BANNER, 20, 220,"mybanner");
        }
        if (GUI.Button(new Rect(240, 100, 100, 60), "removebanner"))
        {
            Admob.Instance().removeBanner();
            Admob.Instance().removeBanner("mybanner");
        }
        
        if (GUI.Button(new Rect(0, 200, 100, 60), "showNative"))
        {
            Admob.Instance().showNativeBannerRelative(nativeBannerID,new AdSize(320,280), AdPosition.BOTTOM_CENTER);
        }
        if (GUI.Button(new Rect(120, 200, 100, 60), "showNativeABS"))
        {
            Admob.Instance().showNativeBannerAbsolute(nativeBannerID,new AdSize(-1,132), 0, 300);
        }
        if (GUI.Button(new Rect(240, 200, 100, 60), "removeNative"))
        {
            Admob.Instance().removeNativeBanner();
        }
	}
    void onInterstitialEvent(string eventName, string msg)
    {
        Debug.Log("handler onAdmobEvent---" + eventName + "   " + msg);
        if (eventName == AdmobEvent.onAdLoaded)
        {
            Admob.Instance().showInterstitial();
        }
    }
    void onBannerEvent(string eventName, string msg)
    {
        Debug.Log("handler onAdmobBannerEvent---" + eventName + "   " + msg);
    }
    void onRewardedVideoEvent(string eventName, string msg)
    {
        Debug.Log("handler onRewardedVideoEvent---" + eventName + "  rewarded: " + msg);
    }
    void onNativeBannerEvent(string eventName, string msg)
    {
        Debug.Log("handler onAdmobNativeBannerEvent---" + eventName + "   " + msg);
    }
}
*/