using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

    [SerializeField] GameObject _whatIsText;    

    public void PlayGame() {
        SceneManager.LoadScene("SampleScene");
    }

    public void WhatIsCubewalk() {
        _whatIsText.SetActive(true);
    }

    public void UhhOkay() {
        _whatIsText.SetActive(false);
    }


}
