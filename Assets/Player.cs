using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
  
    // Default Values
    private float _currentTilt = 0f;
    private Vector3 _moveDirection = Vector3.zero;
    
    // Seialized Values
    [SerializeField] float _mouseSensitivity = 10f;
    [SerializeField] float _movementSpeed = 4.5f;
    [SerializeField] float _jumpSpeed = 3.5f;
    [SerializeField] float _gravity = 9f;

    // References
    [SerializeField] Camera _cam;
    private CharacterController _controller;



    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        _controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Aim();
        Move();
    }

    void Aim()
    {
        float deltaMouseX = Input.GetAxis("Mouse X");
        float deltaMouseY = Input.GetAxis("Mouse Y");

        transform.Rotate(Vector3.up, deltaMouseX * _mouseSensitivity);

        // Rotating around the y axis
        _currentTilt += deltaMouseY * _mouseSensitivity;
        _currentTilt = Mathf.Clamp(_currentTilt, -90, 90);
        _cam.transform.localEulerAngles = new Vector3(-1 * _currentTilt, 0, 0);
    }

    void Move() {
        if (_controller.isGrounded) {
            _moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            _moveDirection = transform.TransformDirection(_moveDirection);
            _moveDirection *= _movementSpeed;

            //Jumps
            if (Input.GetKeyDown("space"))
            {
                _moveDirection.y += _jumpSpeed;
            }
        } else {
            _moveDirection = new Vector3(Input.GetAxis("Horizontal"), _moveDirection.y, Input.GetAxis("Vertical"));
            _moveDirection = transform.TransformDirection(_moveDirection);
            _moveDirection.x *= _movementSpeed;
            _moveDirection.z *= _movementSpeed;
        }
        _moveDirection.y -= _gravity * Time.deltaTime;
        _controller.Move(_moveDirection * Time.deltaTime);
    }


}
