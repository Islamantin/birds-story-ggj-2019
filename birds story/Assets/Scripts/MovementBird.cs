using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class MovementBird : MonoBehaviour
{
    public Animator animator;
    public Vector2 jumpForce = new Vector2();
    public float jumpPower = 1f;
    public Transform transformToFlip;
    public BirdStatus status;
    public float staminaReduceByJump;

    private Rigidbody2D rb;
    private Camera m_camera;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        m_camera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && (status && status.CurrentStamina > 0f))
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            bool side = true;
            if (Input.mousePosition.x < m_camera.WorldToScreenPoint(transform.position).x)
                side = false;

            Jump(side);
        }

        //Vector2 stagePos = Camera.main.WorldToScreenPoint(transform.position);

        //if(stagePos.y > Screen.height || stagePos.y < 0)
        //{
        //    die();
        //}
    }

    public void Jump(bool toRight)
    {
        var side = toRight ? 1f : -1f;
        var jumpVector = new Vector2(Mathf.Abs(jumpForce.x) * side, jumpForce.y);
        rb.AddForce(jumpVector * jumpPower);

        var s = transformToFlip.localScale;
        transformToFlip.localScale = new Vector3(Mathf.Abs(s.x) * side, s.y, s.z);

        animator.SetTrigger("jump");

        if (status)
            status.AddStamina(staminaReduceByJump);
    }

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    die();
    //}

    //void die()
    //{
    //    Application.LoadLevel(Application.loadedLevel);
    //}
}
