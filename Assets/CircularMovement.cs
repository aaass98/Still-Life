using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircularMovement : MonoBehaviour
{
    //will rotate object with defined angular speed, center and around a defined axis. Radius = distance from center to object transform;
    [SerializeField] private float angularSpeed;
    private float alpha;
    [SerializeField] private Vector3 rotationCenter;
    [SerializeField] private Vector3 rotationAxis;

    // Update is called once per frame
    private void Start()
    {

    }
    void Update()
    {
        Vector3 direction = transform.position - rotationCenter;
        transform.position = transform.position + Vector3.Cross(direction, rotationAxis.normalized) * angularSpeed * Time.deltaTime;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireCube(rotationCenter, Vector3.one);
    }
}
