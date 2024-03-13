using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud : MonoBehaviour
{
    public Transform[] planetObj;
    static public string spawnedYet = "n";
    static public Vector2 cloudPos;


    void Start()
    {

    }


    void Update()
    {
        spawnPlanet();

        if (Input.GetKey("a"))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-2, 0);
        }

        if (Input.GetKey("d"))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(2, 0);
        }

        if ((!Input.GetKey("a")) && (!Input.GetKey("d")))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        }
        cloudPos = transform.position;
    }

    void spawnPlanet()
    {
        if (spawnedYet == "n")
        {
            StartCoroutine(spawntimer().ToString());
            spawnedYet = "y";
        }
    }

    IEnumerable spawntimer()
    {
        yield return new WaitForSeconds(.75f);
        Instantiate(planetObj[Random.Range(0, 3)], transform.position, planetObj[0].rotation);
    }
}
