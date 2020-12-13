using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walkway : MonoBehaviour
{
    private GameObject _light;
    void Start()
    {
        _light = transform.parent.Find("Spot Light").gameObject;
        _light.SetActive(false);
    }

    private void OnTriggerEnter(Collider other) {
        _light.SetActive(true);    
    }

    private void OnTriggerExit(Collider other) {
        _light.SetActive(false);
    }
}
