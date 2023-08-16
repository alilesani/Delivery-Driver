using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] private Transform  _transform;
    [SerializeField] private float _moveSpeed = 0.01f;
    [SerializeField] private float _steerSpeed = -0.25f;
    private void Update() {
        _transform.Rotate(0, 0, _steerSpeed * Time.deltaTime);
        _transform.Translate(0, _moveSpeed * Time.deltaTime, 0);
    }
}
