using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nest : MonoBehaviour
{
    [SerializeField]
    private GameObject[] elements;

    private int currentInd = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("bird"))
        {
            var status = other.GetComponent<BirdStatus>();
            if (status && status.HasStick)
            {
                status.SetStickStatus(false);
                elements[currentInd++].SetActive(true);

                status.AddScoreToBird(1);
            }
        }
    }
}
