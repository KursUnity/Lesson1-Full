using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public float speed = 5f; // Переменная для скорости

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal"); // Получаем горизонтальное движение
        float moveVertical = Input.GetAxis("Vertical"); // Получаем вертикальное движение

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical); // Создаем вектор движения

        transform.Translate(movement * speed * Time.deltaTime); // Перемещаем объект
    }
}
