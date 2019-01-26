using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEngine : MonoBehaviour
{

    public GameObject bottomTree;
    public GameObject upperTree;
    public GameObject bird;
    public float treeHole;

    // Start is called before the first frame update
    void Start()
    {

        InvokeRepeating("CreateObstacle", 0f, 1.5f);

    }
    
    void CreateObstacle()
    {
        float randomPos = 4f - (4f - 0.8f - treeHole) * Random.value;

        GameObject upperTree = Instantiate(bottomTree);

        upperTree.transform.position = new Vector2(4f, randomPos);

        GameObject lowerTree = Instantiate(upperTree);

        lowerTree.transform.position = new Vector2(4f, upperTree.transform.position.y - treeHole - 2f* Random.value);
    }
}
