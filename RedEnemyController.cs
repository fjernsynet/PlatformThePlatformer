using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedEnemyController : MonoBehaviour
{
  public float speed = 1.19f;
Vector3 pointA;
Vector3 pointB;

void Start()
{
    pointA = new Vector3(19, -4, 0);
    pointB = new Vector3(31, -4, 0);
}

void Update()
{
    //PingPong between 0 and 1
    float time = Mathf.PingPong(Time.time * speed, 1);
    transform.position = Vector3.Lerp(pointA, pointB, time);
}
}
