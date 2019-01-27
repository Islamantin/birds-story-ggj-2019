using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BranchSpawner : MonoBehaviour
{

    public GameObject branch;
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
            float side = Random.value;
            if (side >= 0.5f)
            {
                SpawnRight();
            }
            else
            {
                SpawnLeft();
            }
            counter = Random.Range(120f, 600f);
        }
    }

    void SpawnLeft()
    {
        GameObject branch_instance = Instantiate(branch);

        branch.transform.position = new Vector2(Random.Range(leftBorder,-2f),topBorder);
        //Debug.Log("left");
    }
    void SpawnRight()
    {
        GameObject branch_instance = Instantiate(branch);
        //Debug.Log("right");
        branch.transform.position = new Vector2(Random.Range(2f,rightBorder), topBorder);
    }
}
