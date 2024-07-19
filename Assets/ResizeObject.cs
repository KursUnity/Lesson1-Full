using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResizeObject : MonoBehaviour
{
    public float resizeSpeed = 1f; // ���������� ��� �������� ��������� �������

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)) // ���� ������ ������� �����
        {
            transform.localScale += new Vector3(1, 1, 1) * resizeSpeed; // ����������� ������
        }

        if (Input.GetKeyDown(KeyCode.DownArrow)) // ���� ������ ������� ����
        {
            transform.localScale -= new Vector3(1, 1, 1) * resizeSpeed; // ��������� ������
        }
    }
}
