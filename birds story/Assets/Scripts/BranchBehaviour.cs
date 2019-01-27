using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BranchBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().AddForce(Vector2.up*10);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        switch (collider.tag)
        {
            case "bird":
                collider.GetComponent<BirdStatus>().AddStamina(50);
                Destroy(gameObject);
                break;
            case "dead":
                Destroy(gameObject);
                break;
        }
    }
}
