using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour
{
    
    public GameObject planetPrefab;
    public float dropForce = 1f;
    public bool isMerging;

    public GameObject nextPlanet;

    public int points;

    private string intheCloud = "y";

   
    void Update()
    {
        if (intheCloud=="y")
        {
            GetComponent<Transform>().position = Cloud.cloudPos;
        }

        if (Input.GetKeyDown("space"))
        {
            GetComponent<Rigidbody2D>().gravityScale = 1;
            intheCloud = "n";
            Cloud.spawnedYet = "n";
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(isMerging) return;
        if (!collision.gameObject.CompareTag("Planet")) return;
        if (points != collision.gameObject.GetComponent<Planet>().points) return;

        isMerging = true;
        collision.gameObject.GetComponent<Planet>().isMerging = true;
        
        Destroy(gameObject);
        Destroy(collision.gameObject);

        var middlePos = transform.position + collision.transform.position / 2;
        Instantiate(nextPlanet, middlePos, Quaternion.identity);
              
    }
}
