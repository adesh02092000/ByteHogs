using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelInit : MonoBehaviour
{
    private string modelSelected;
    private GameObject modelPrefab;
    private void Awake()
    {
        modelSelected = PlayerPrefs.GetString("SelModel");
        modelPrefab = GameObject.FindGameObjectWithTag(modelSelected);
        Instantiate(modelPrefab, new Vector3(0, 0, 0), Quaternion.identity);
    }
}
