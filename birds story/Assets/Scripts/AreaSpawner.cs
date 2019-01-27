using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaSpawner : MonoBehaviour
{

    public GameObject[] objectsToSpawn;
    public float leftBorder;
    public float rightBorder;
    public float topBorder;
    public float downBorder;
    float counter;
    // Start is called before the first frame update
    void Start()
    {
        counter = Random.Range(120f, 600f);
    }

    // Update is called once per frame
    void Update()
    {
        counter--;
        if (counter <= 0)
        {
            Spawn();
            //float side = Random.value;
            //if (side >= 0.5f)
            //{
            //    SpawnRight();
            //}
            //else
            //{
            //    SpawnLeft();
            //}
            counter = Random.Range(120f, 600f);
        }
    }

    //void SpawnLeft()
    //{
    //    GameObject instance = Instantiate(objectsToSpawn[Random.Range(0, objectsToSpawn.Length)]);

    //    instance.transform.position = new Vector2(Random.Range(leftBorder, (rightBorder-leftBorder)/2),topBorder);
    //    //Debug.Log("left");
    //}
    //void SpawnRight()
    //{
    //    GameObject instance = Instantiate(objectsToSpawn[Random.Range(0, objectsToSpawn.Length)]);
    //    //Debug.Log("right");
    //    instance.transform.position = new Vector2(Random.Range((rightBorder - leftBorder) / 2, rightBorder), topBorder);
    //}

    void Spawn()
    {
        GameObject instance = Instantiate(objectsToSpawn[Random.Range(0, objectsToSpawn.Length)]);
        var x = Random.Range(leftBorder, rightBorder);
        var y = Random.Range(downBorder, topBorder);
        instance.transform.position = new Vector2(x, y);

    }
}