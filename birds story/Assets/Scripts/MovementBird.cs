using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBird : MonoBehaviour
{
    public Animator animator;
    public Vector2 jumpForce = new Vector2();

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector2(-2f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetBool("Space", true);
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            GetComponent<Rigidbody2D>().AddForce(jumpForce);
        }
        if(Input.GetKeyUp(KeyCode.Space))
        animator.SetBool("Space", false);

        Vector2 stagePos = Camera.main.WorldToScreenPoint(transform.position);

        if(stagePos.y > Screen.height || stagePos.y < 0)
        {
            die();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        die();
    }

    void die()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
}
