using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEnding : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player") && Input.GetKeyDown("e")) {
            UnityEngine.SceneManagement.SceneManager.LoadScene(3);
        }
    }
}
