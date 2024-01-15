using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashCanVisibility : MonoBehaviour
{
    public GameObject viewpoint;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            viewpoint.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            viewpoint.SetActive(false);
        }
    }
}
