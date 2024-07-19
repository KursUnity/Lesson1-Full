using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResizeObject : MonoBehaviour
{
    public float resizeSpeed = 1f; // Переменная для скорости изменения размера

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)) // Если нажата стрелка вверх
        {
            transform.localScale += new Vector3(1, 1, 1) * resizeSpeed; // Увеличиваем размер
        }

        if (Input.GetKeyDown(KeyCode.DownArrow)) // Если нажата стрелка вниз
        {
            transform.localScale -= new Vector3(1, 1, 1) * resizeSpeed; // Уменьшаем размер
        }
    }
}
