using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class FTM : MonoBehaviour
{
    public void MainCam()
    {
        // Debug.Log(EventSystem.current.currentSelectedGameObject.name);
        PlayerPrefs.SetString("SelModel", EventSystem.current.currentSelectedGameObject.name);
        SceneManager.LoadScene("Main");
    }
}
