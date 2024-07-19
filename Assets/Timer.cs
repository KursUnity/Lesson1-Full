using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timeRemaining = 10f; // Время которое осталось
    public Text timerText; // Текстовый элемент для отображения времени


    void Update()
    {
        if (timeRemaining > 0) // Если время ещё не закончилось
        {
            timeRemaining -= Time.deltaTime; // Уменьшаем оставшееся время
            timerText.text = "Time: " + Mathf.Round(timeRemaining).ToString(); // Обновляем текст таймера
        }
        else
        {
            timerText.text = "Time`s up!"; // Если время закончилось
        }
    }
}
