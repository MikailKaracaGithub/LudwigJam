using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorRotate : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed = 10;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Rotate(Vector3.right * _rotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Rotate(-Vector3.right * _rotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.forward * _rotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(-Vector3.forward * _rotationSpeed * Time.deltaTime);
        }
    }
}
