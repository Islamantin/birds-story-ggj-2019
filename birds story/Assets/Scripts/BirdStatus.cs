using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdStatus : MonoBehaviour
{

    public SpriteRenderer rendererToFade;
    public GameObject stickObject;

    public float maxStamina;

    public int score = 0;
    public int addScore = 1;

    public bool HasStick { get; private set; }
    public float CurrentStamina { get; private set; }


    private void Start()
    {
        CurrentStamina = maxStamina;
    }

    public void AddStamina(float add)
    {
        if (CurrentStamina + add < maxStamina)
        {
            if (CurrentStamina + add > 0f)
            {
                CurrentStamina += add;
            }
            else CurrentStamina = 0f;
        }
        else CurrentStamina = maxStamina;

        var value = CurrentStamina / maxStamina;
        var c = rendererToFade.color;
        rendererToFade.color = new Color (c.r, c.g, c.b, value);
    }

    public void SetStickStatus(bool stickStatus)
    {
        HasStick = stickStatus;
        stickObject.SetActive(stickStatus);
    }

    public void AddScoreToBird(int score_added)
    {
        score += score_added;

        if(score >= 8)
        {
            SceneManager.LoadScene(0);
        }
    }
}
