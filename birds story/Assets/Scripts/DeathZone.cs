using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class DeathZone : MonoBehaviour
{

    public Animator uiAnimator;
    public float restartDelay = 1f;

    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.CompareTag("bird"))
        {
            var stat = coll.gameObject.GetComponent<BirdStatus>();
            stat.AddStamina(-stat.maxStamina);
            uiAnimator.SetTrigger("fadein");
            StartCoroutine(WaitAndRestart());
        }
    }

    IEnumerator WaitAndRestart()
    {
        yield return new WaitForSeconds(restartDelay);
        SceneManager.LoadScene(0);
    }
}
