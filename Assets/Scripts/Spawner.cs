using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float spawnSpeed = 1f;
    public GameObject planetPrefab;


    
    void Start()
    {
        Spawn();
    }

    
    async void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            Spawn();

        }

    }

    public void Spawn()
    {
        var obj = Instantiate(planetPrefab);
        var x = Random.Range(-2f, 2f);
        obj.transform.position = new Vector3(x, 4, 0);
    }
}

