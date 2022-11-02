using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Move_and_Delete : MonoBehaviour
{
    public GameObject cube;

    public float speed;
    private float progress;

    public Vector3 startPosition;
    public Vector3 endPosition;

    public void ChangeDistanceZ(string changedistanceZ)
    {
        endPosition.z = float.Parse(changedistanceZ);
        endPosition.y = 0.244f;
    }

    public void ChangeDistanceX(string changedistanceX)
    {
        endPosition.x = float.Parse(changedistanceX);
        endPosition.y = 0.244f;
    }
    public void Changespeedinputfield(string changespeed)
    {
        speed = float.Parse(changespeed);
    }
    public void DistanceValueZ(float distanceendz)
    {
        endPosition.z = distanceendz;
        endPosition.y = 0.244f;
    }

    public void DistanceValueX(float distanceendx)
    {
        endPosition.x = distanceendx;
        endPosition.y = 0.244f;
    }
    public void Speedvalue(float speed1)
    {
        speed = speed1;
        progress += speed1;
    }

    private void Start()
    {
        transform.position = startPosition;
    }

    void FixedUpdate()
    {
        transform.position = Vector3.Lerp(startPosition, endPosition, progress * Time.deltaTime);
        Speedvalue(speed);

        if (transform.position == endPosition)
        {
            Destroy(gameObject);
        }

    }

    
}
