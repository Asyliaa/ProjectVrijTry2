using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{


    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown("e") && other.transform.CompareTag("Player"));
        {
            SceneManager.LoadScene(3);
        }   
    }
}
