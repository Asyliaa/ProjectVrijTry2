using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingTriggerScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }


    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Ending"))
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
    }
}


