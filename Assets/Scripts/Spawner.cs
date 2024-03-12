using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float spawnSpeed = 1f;
    public List<GameObject> planetPrefabs;


    
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
        var obj = Instantiate(planetPrefabs[Random.Range(0, planetPrefabs.Count)]);
        var x = Random.Range(-2f, 2f);
        obj.transform.position = new Vector3(x, 4, 0);
    }
}

