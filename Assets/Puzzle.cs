using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Puzzle : MonoBehaviour
{

    [SerializeField] GameObject _indicator;
    [SerializeField] RuntimeData _runtimeData;
    private bool _solved = false;

    // Update is called once per frame
    void Update()
    {
        _solved = !(_runtimeData._activeCubes.Except(_runtimeData._solveCubes).Any()) && (_runtimeData._activeCubes.Count == _runtimeData._solveCubes.Count);
        if (_solved) {
            _indicator.GetComponent<MeshRenderer>().material = _runtimeData._indicatorMaterial;
        } else {
            _indicator.GetComponent<MeshRenderer>().material = _runtimeData._inactiveMaterial;
        }
    }
}
