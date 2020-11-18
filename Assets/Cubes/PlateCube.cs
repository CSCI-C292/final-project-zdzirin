using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateCube : MonoBehaviour
{
    private bool _isActive = false;
    private MeshRenderer _meshRenderer;
    [SerializeField] RuntimeData _runtimeData;
 
    // Start is called before the first frame update
    void Start()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_isActive)
        {
            _meshRenderer.material = _runtimeData._activeMaterial;
        }
        else
        {
            _meshRenderer.material = _runtimeData._inactiveMaterial;
        }
    }

    private void OnTriggerEnter(Collider other) {
        _isActive = !_isActive;
    }

    public bool GetActive() { return _isActive; }

}
