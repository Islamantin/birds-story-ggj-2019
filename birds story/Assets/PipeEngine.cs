using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeEngine : MonoBehaviour
{
    public Vector2 pipeVelocity = new Vector2();

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = pipeVelocity;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < -8)
        {
            Destroy(gameObject);
        }
    }
}
