using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Puzzle : MonoBehaviour
{

    [SerializeField] GameObject _indicator;
    [SerializeField] RuntimeData _runtimeData;
    private bool _solved = false;
    private GameObject _pointLight;

    private void Start()
    {
        _pointLight = _indicator.transform.Find("Point Light").gameObject;
    }


    // Update is called once per frame
    void Update()
    {
        _solved = !(_runtimeData._activeCubes.Except(_runtimeData._solveCubes).Any()) && (_runtimeData._activeCubes.Count == _runtimeData._solveCubes.Count);
        if (_solved)
        {
            _indicator.GetComponent<MeshRenderer>().material = _runtimeData._indicatorMaterial;
            _pointLight.SetActive(true);
            _runtimeData._solved = true;
        }
        else
        {
            _indicator.GetComponent<MeshRenderer>().material = _runtimeData._inactiveMaterial;
            _pointLight.SetActive(false);
            _runtimeData._solved = false;
        }
    }
}
