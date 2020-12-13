using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinDoor : MonoBehaviour
{

    [SerializeField] RuntimeData _runtimeData;
    [SerializeField] float _speed = 0.5f;

    [SerializeField] float _floorHeight = 2.5f;
    [SerializeField] float _height = 7.5f;
    void Update()
    {
        if (_runtimeData._solved && !_runtimeData._showingSolution) {
            if (transform.position.y < _height) {
                transform.position += new Vector3(0, _speed * Time.deltaTime, 0);
            }
        } else {
            if (transform.position.y > _floorHeight) {
                transform.position -= new Vector3(0,_speed * Time.deltaTime,0);
                transform.position = (transform.position.y < 2.5) ? new Vector3(transform.position.x,2.5f,transform.position.z) : transform.position;
            }
        }
    }
}
