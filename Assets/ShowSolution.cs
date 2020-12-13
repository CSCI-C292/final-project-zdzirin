using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowSolution : MonoBehaviour
{
    [SerializeField] RuntimeData _runtimeData;

    private void OnTriggerEnter(Collider other)
    {
        _runtimeData._showingSolution = true;
        foreach (string cube in _runtimeData._solveCubes)
        {
            PlateCube script = GameObject.Find(cube).transform.Find("PlateCube").gameObject.GetComponent<PlateCube>();
            script.SetActive();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        foreach (string cube in _runtimeData._solveCubes)
        {
            PlateCube script = GameObject.Find(cube).transform.Find("PlateCube").gameObject.GetComponent<PlateCube>();
            script.SetInactive();
        }
        _runtimeData._showingSolution = false;
    }

}
