using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedEnemyController2 : MonoBehaviour
{
  public float speed = 1.19f;
Vector3 pointA;
Vector3 pointB;

void Start()
{
    pointA = new Vector3(34, -6, 0);
    pointB = new Vector3(54, -6, 0);
}

void Update()
{
    //PingPong between 0 and 1
    float time = Mathf.PingPong(Time.time * speed, 1);
    transform.position = Vector3.Lerp(pointA, pointB, time);
}
}
