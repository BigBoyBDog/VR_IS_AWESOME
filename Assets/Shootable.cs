using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Shootable : MonoBehaviour
{

    public GameObject killEffect;
    public GameObject sphere;
    private SphereScore sphereScore;


    void Start()
    {
        sphereScore = FindObjectOfType<SphereScore>();
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bullet"))
        {
            Instantiate(killEffect, sphere.transform.position, sphere.transform.rotation);
            sphereScore.IncreaseScore(1);
            Destroy(gameObject);
        }
    }

}
