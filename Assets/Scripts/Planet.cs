using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour
{
    Rigidbody2D rb;
    public GameObject planetPrefab;
    public float dropForce = 1f;
    public bool isMerging;

    public GameObject nextPlanet;

    public int points;
  
    void Start()
    {


    }
   
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (rb == null)
            {
                rb = planetPrefab.AddComponent<Rigidbody2D>();
                rb.AddForce(Vector3.down * dropForce, ForceMode2D.Force);
            }


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
