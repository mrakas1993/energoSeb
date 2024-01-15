using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneINPUT : MonoBehaviour
{
    public string sceneName;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadSceneAsync(sceneName);
        }
    }
}