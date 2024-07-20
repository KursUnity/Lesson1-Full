using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer_2 : MonoBehaviour
{
    public float timeRemaining = 10f; // ����� ������� ��������
    public Text timerText; // ��������� ������� ��� ����������� �������

    void Update()
    {
        if (timeRemaining > 0) // ���� ����� �� �����������
        {
            timeRemaining -= Time.deltaTime; // ��������� �����
            timerText.text = "Time: " + Mathf.Round(timeRemaining).ToString(); // ��������� ����� �������
        }
        else
        {
            timerText.text = "Time`s up!"; // ���� ����� �����������
        }
    }
}