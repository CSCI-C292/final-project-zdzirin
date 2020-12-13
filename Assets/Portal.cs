using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{

    [SerializeField] string _sceneName = "";

    private void OnTriggerEnter(Collider other) {
        if (_sceneName != "") {
            SceneManager.LoadScene(_sceneName);
        }
    }
}
