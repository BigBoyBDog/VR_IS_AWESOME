using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnCrates : MonoBehaviour
{
    public Vector3 crateLocation;
    public Quaternion crateRotation;

    public void Respawn()
    {
        transform.position = crateLocation;
        transform.rotation = crateRotation;
    }
    
}
