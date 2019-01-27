using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetBackZone : MonoBehaviour
{
    public bool isLeft;

    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.CompareTag("bird"))
        {
            coll.GetComponent<MovementBird>().Jump(isLeft);
        }
    }
}
