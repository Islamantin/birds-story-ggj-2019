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



    }
    
    //void CreateObstacle()
    //{
    //    float randomPos = 4f - (4f - 0.8f - treeHole) * Random.value;

    //    GameObject upperTree = Instantiate(upperTree);

    //    upperTree.transform.position = new Vector2(3f, randomPos);

    //    GameObject lowerTree = Instantiate(bottomTree);

    //    lowerTree.transform.position = new Vector2(3f, randomPos - treeHole - 3f * Random.value);
    //}
}
