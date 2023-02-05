using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
   Vector3 startingPosition;

void Start ()
{
    startingPosition = gameObject.transform.position;
}

void Update ()
{
    if (gameObject.transform.position.z >= 15) {
        gameObject.transform.position = startingPosition;

    } else {
        float translation = Time.deltaTime * 2;
        transform.Translate (0, 0, translation);
        transform.Translate (Vector3.forward * translation);
    }
}
}
