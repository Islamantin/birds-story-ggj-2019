using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeScript : MonoBehaviour
{
    // Эта глобальная переменная будет установлена из инспектора. Представляет скорость препятствия
    public Vector2 pipeVelocity = new Vector2();

    // function to be executed once the pipe is created
    void Start()
    {
        // Настройка скорости компонента rigid body присоединённого к препятствию
        GetComponent<Rigidbody2D>().velocity = pipeVelocity;
    }

    // function to be executed at each frame
    void Update()
    {
        // Проверка позиции x
        if (transform.position.x < -4)
        {
            // Уничтожение препятствия и оцистка памяти
            Destroy(gameObject);
        }
    }
}