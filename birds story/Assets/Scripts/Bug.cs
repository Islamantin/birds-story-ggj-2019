using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bug : MonoBehaviour
{

    public float lifeTime = 2f;

    void Update()
    {
        if (lifeTime > 0f)
            lifeTime -= Time.deltaTime;
        else Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        switch (collider.tag)
        {
            case "bird":
                var status = collider.GetComponent<BirdStatus>();
                if (status && !status.HasStick)
                {
                    status.AddStamina(50);
                    Destroy(gameObject);
                }
                break;
            //case "dead":
            //    Destroy(gameObject);
            //    break;
        }
    }
}
