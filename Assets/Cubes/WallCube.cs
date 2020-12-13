using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCube : MonoBehaviour
{

    [SerializeField] GameObject _targetCube;
    private PlateCube _targetCubeScript;

    private MeshRenderer _meshRenderer;
    private GameObject _greenLight;
    private GameObject _light;
    [SerializeField] RuntimeData _runtimeData;

    // Start is called before the first frame update
    void Start()
    {
        _targetCubeScript = _targetCube.transform.Find("PlateCube").gameObject.GetComponent<PlateCube>();
        _meshRenderer = GetComponent<MeshRenderer>();
        _greenLight = transform.Find("Green Light").gameObject;
        _light = transform.Find("Light").gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (_targetCubeScript.GetActive())
        {
            _meshRenderer.material = _runtimeData._activeMaterial;
            _greenLight.SetActive(true);
            _light.SetActive(false);
        }
        else
        {
            _meshRenderer.material = _runtimeData._inactiveMaterial;
            _greenLight.SetActive(false);
            _light.SetActive(true);
        }
    }
}
