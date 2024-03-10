using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour
{
    Rigidbody2D rb;
    public GameObject planetPrefab;
    public float dropForce = 1f;
  
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
}
