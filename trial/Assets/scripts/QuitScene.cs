using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitScene : MonoBehaviour
{
public void QuitGame()
{
    Application.Quit();
    Debug.Log("Quit");
}
}
