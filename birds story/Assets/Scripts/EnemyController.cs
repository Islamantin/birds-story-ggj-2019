using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    public GameObject enemy;
    public GameObject player;

    [Range(0.01f, 4f)]
    public float diff = 1f;

    public int timer = 10;
    private float time;

    private BoxCollider2D coll;

    private bool lookingTarget;

    // Start is called before the first frame update
    void Start()
    {
        lookingTarget = true;
        time = timer;
        coll = GetComponent<BoxCollider2D>();
    }

    private Transform pos;

    // Update is called once per frame
    void Update()
    {
        if (time < 0)
        {
            time = timer;
            var bounds = coll.bounds;
            var center = bounds.center;
            var x = UnityEngine.Random.Range(center.x - bounds.extents.x, center.x + bounds.extents.x);
            var y = UnityEngine.Random.Range(center.y - bounds.extents.y, center.y + bounds.extents.y);

            Vector2 posEnemy = new Vector2(x, y);
            GameObject enemyBird;
            enemyBird = Instantiate(enemy, new Vector2(x,y), Quaternion.identity);

            if (posEnemy.x > player.transform.position.x)
            {
                var scale = enemyBird.transform.localScale;
                enemyBird.transform.localScale = new Vector3(scale.x, Mathf.Abs(scale.y) * -1, scale.z);

                enemyBird.GetComponent<EnemyAttack>().inverse = true;
            }

            Attack(enemyBird);
        }
        time -= Time.deltaTime * diff;
    }

    void Moving(GameObject enemy)
    {

    }

    void Attack(GameObject enemy)
    {
        if (lookingTarget)
        {
            
        }
    }
}
