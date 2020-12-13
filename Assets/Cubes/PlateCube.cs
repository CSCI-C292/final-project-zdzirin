using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateCube : MonoBehaviour
{
    private bool _isActive = false;
    private MeshRenderer _meshRenderer;
    [SerializeField] RuntimeData _runtimeData;
    private GameObject _light;
 
    // Start is called before the first frame update
    void Start()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
        _light = transform.Find("Light").gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        _light.SetActive(_isActive);
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
        if (other.name == "Character") {
            _isActive = !_isActive;
            if (_isActive) {
                Debug.Log(this.transform.parent.gameObject);
                _runtimeData._activeCubes.Add(this.transform.parent.name);
            } else {
                _runtimeData._activeCubes.Remove(this.transform.parent.name);
            }
        }
    }

    public bool GetActive() { return _isActive; }

    public void SetInactive() { 
        _isActive = false; 
        _runtimeData._activeCubes.Remove(this.transform.parent.name);
    }

    public void SetActive()
    {
        _isActive = true;
        _runtimeData._activeCubes.Add(this.transform.parent.name);
    }

}
