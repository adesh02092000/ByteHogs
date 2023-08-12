﻿using System.Collections;
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
                modelPrefab = Instantiate(Nuike, new Vector3(1.4f, -7.1f, -16.3f), Quaternion.identity);
                modelPrefab.transform.parent = imageTracker.transform;
                GameObject child = imageTracker.transform.GetChild(0).gameObject;
                Debug.Log("john");
                Debug.Log(child.name);
                Debug.Log("Doe");
                break;

            case "Whuietie":
                modelPrefab = Instantiate(Whuietie, new Vector3(-0.056372f, -3.8f, -11.083f), Quaternion.Euler(-90, 0, 0));
                modelPrefab.transform.parent = imageTracker.transform;
                break;

            case "Sepoeikeis":
                modelPrefab = Instantiate(Sepoeikeis, new Vector3(0.1f, -0.1f, -8.2f), Quaternion.Euler(-90, 0, 0));
                modelPrefab.transform.parent = imageTracker.transform;
                break;

            case "BBS":
                modelPrefab = Instantiate(BBS, new Vector3(0.7f, -1.72f, -5.8f), Quaternion.identity);
                modelPrefab.transform.parent = imageTracker.transform;
                break;

            default:
                Debug.Log("yolo");
                break;

        }
    }
}
