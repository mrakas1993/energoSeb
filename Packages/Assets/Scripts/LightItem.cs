using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightItem : MonoBehaviour
{
    private Outline outline; // ������ �� ������ �������

    void Start()
    {
        outline = GetComponent<Outline>();
        if (outline == null)
        {
            // ���� ������ ������� �� ������, �������� ���
            outline = gameObject.AddComponent<Outline>();
        }
        outline.enabled = false; // ���������� ��������� �������
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Highlight();
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Unhighlight();
        }
    }

    void Highlight()
    {
        outline.enabled = true; // �������� �������
    }

    void Unhighlight()
    {
        outline.enabled = false; // ��������� �������
    }
}
