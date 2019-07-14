using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelInit : MonoBehaviour
{
    private string modelSelected;
    private GameObject modelPrefab;
    public GameObject imageTracker;


    // prefabs
    public GameObject Nuike;
    public GameObject Whuietie;
    public GameObject Sepoeikeis;
    public GameObject BBS;
    void Start() {
        Debug.Log("yoloooo");
        modelSelected = PlayerPrefs.GetString("SelModel");
        //imageTracker = GameObject.Find("ImageTarget");
        switch(modelSelected) {
            case "Nuike":
                Debug.Log("Nuike");
                modelPrefab = Instantiate(Nuike, new Vector3(1.1f, -13.5f, -16.9f), Quaternion.identity);
                modelPrefab.transform.parent = imageTracker.transform;
                GameObject child = imageTracker.transform.GetChild(0).gameObject;
                Debug.Log("john");
                Debug.Log(child.name);
                Debug.Log("Doe");
                break;

            case "Whuietie":
                modelPrefab = Instantiate(Whuietie, new Vector3(5.34f, -5.07f, -0.46f), Quaternion.identity);
                modelPrefab.transform.parent = imageTracker.transform;
                break;

            case "Sepoeikeis":
                modelPrefab = Instantiate(Sepoeikeis, new Vector3(11.12f, 0, 5.8f), Quaternion.identity);
                modelPrefab.transform.parent = imageTracker.transform;
                break;

            case "BBS":
                modelPrefab = Instantiate(BBS, new Vector3(-1.1f, -8.7f, -7.8f), Quaternion.identity);
                modelPrefab.transform.parent = imageTracker.transform;
                break;

            default:
                Debug.Log("yolo");
                break;

        }
    }
}
