using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCube : MonoBehaviour
{

    [SerializeField] GameObject _targetCube;
    private PlateCube _targetCubeScript;
    
    private MeshRenderer _meshRenderer;
    [SerializeField] RuntimeData _runtimeData;

    // Start is called before the first frame update
    void Start()
    {
        _targetCubeScript = _targetCube.transform.Find("PlateCube").gameObject.GetComponent<PlateCube>();
        _meshRenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_targetCubeScript.GetActive()) {
            _meshRenderer.material = _runtimeData._activeMaterial;
        }
            else
        {
            _meshRenderer.material = _runtimeData._inactiveMaterial;
        }
    }
}
