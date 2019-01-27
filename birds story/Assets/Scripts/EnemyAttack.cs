using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{

    private bool looking;
    public bool inverse;

    private GameObject player;

    public int timer = 5;
    private float time;

    private Rigidbody2D rb2;
    public float boostSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("bird");
        looking = true;
        time = timer;

        rb2 = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        Debug.Log(player.transform.position);

        time -= Time.deltaTime;

        if (looking)
        {
            Vector3 vectorToTarget = player.transform.position - transform.position;
            float angle = Mathf.Atan2(vectorToTarget.y, vectorToTarget.x) * Mathf.Rad2Deg;
            Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
            transform.rotation = Quaternion.Slerp(transform.rotation, q, Time.deltaTime);
        } 

        if(time < 0)
        {
            looking = false;
            transform.position += transform.right * Time.deltaTime * boostSpeed;
        }

        if(time < -timer * 3)
        {
            Destroy(gameObject);
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("kek");
        if (collision.collider.CompareTag("bird"))
        {
            collision.collider.GetComponent<Rigidbody2D>().AddForce(collision.contacts[0].normal * 10f);
        }
    }
}
