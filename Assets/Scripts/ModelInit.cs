using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelInit : MonoBehaviour
{
    private string modelSelected;
    private GameObject modelPrefab;
    private GameObject imageTracker;

    // prefabs
    public GameObject Nuike;
    public GameObject Whuietie;
    public GameObject Sepoeikeis;
    public GameObject BBS;
    private void Awake()
    {
        modelSelected = PlayerPrefs.GetString("SelModel");
        imageTracker = GameObject.Find("ImageTarget");
        switch(modelSelected) {
            case "Nuike":
                modelPrefab = Instantiate(Nuike, new Vector3(0, 0, 0), Quaternion.identity);
                modelPrefab.transform.parent = imageTracker.transform;
                break;

            case "Whuietie":
                modelPrefab = Instantiate(Whuietie, new Vector3(0, 0, 0), Quaternion.identity);
                modelPrefab.transform.parent = imageTracker.transform;
                break;

            case "Sepoeikeis":
                modelPrefab = Instantiate(Sepoeikeis, new Vector3(0, 0, 0), Quaternion.identity);
                modelPrefab.transform.parent = imageTracker.transform;
                break;

            case "BBS":
                modelPrefab = Instantiate(BBS, new Vector3(0, 0, 0), Quaternion.identity);
                modelPrefab.transform.parent = imageTracker.transform;
                break;

            default:
                Debug.Log("yolo");
                break;

        }
    }
}
