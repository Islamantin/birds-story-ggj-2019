using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public GameObject enemy;
    public GameObject player;

    [Range(0.01f, 4f)]
    public float diff = 1f;

    public int timer = 10;
    private float time;

    private BoxCollider2D coll;

    private bool started;

    void Start()
    {
        time = timer;
        coll = GetComponent<BoxCollider2D>();
    }

    private Transform pos;

    public void StartTimer()
    {
        started = true;
    }

    void Update()
    {
        if (!started)
            return;
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
        }
        time -= Time.deltaTime * diff;
    }
}
