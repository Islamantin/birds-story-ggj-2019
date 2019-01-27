using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdStatus : MonoBehaviour
{

    public SpriteRenderer rendererToFade;
    public float maxStamina;

    public bool HasBranch { get; private set; }
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
}
