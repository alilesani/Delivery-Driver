using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] private Transform  _transform;
    [SerializeField] private float _moveSpeed = 0.01f;
    [SerializeField] private float _steerSpeed = -0.25f;
    private void Update() {
        float moveAmount = Input.GetAxis("Vertical") * _moveSpeed;
        float steerAmount = moveAmount != 0 ? Input.GetAxis("Horizontal") * _steerSpeed : 0;
        _transform.Rotate(0, 0, Time.deltaTime * steerAmount);
        _transform.Translate(0, Time.deltaTime * moveAmount, 0);
    }
}
