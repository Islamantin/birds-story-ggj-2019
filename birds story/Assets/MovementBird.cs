using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBird : MonoBehaviour
{
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetBool("Space", true);
        }
        if(Input.GetKeyUp(KeyCode.Space))
        animator.SetBool("Space", false);
    }
}
