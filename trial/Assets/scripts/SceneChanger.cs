using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneChanger : MonoBehaviour
{
 public void selectScene(){
   switch(this.gameObject.name){
     case "but1":
     SceneManager.LoadScene("lvl1");
     break;
      case "but2":
     SceneManager.LoadScene("lvl2");
     break;
      case "but3":
     SceneManager.LoadScene("lvl3");
     break;
      case "but4":
     SceneManager.LoadScene("lvl4");
     break;
      case "but5":
     SceneManager.LoadScene("lvl5");
     break;
      case "but6":
     SceneManager.LoadScene("lvl6");
     break;
      case "but7":
     SceneManager.LoadScene("lvl7");
     break;
      case "but8":
     SceneManager.LoadScene("lvl8");
     break;
      case "but9":
     SceneManager.LoadScene("lvl9");
     break;
   }
 }


}
