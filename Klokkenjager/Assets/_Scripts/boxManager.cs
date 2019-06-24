using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class boxManager : MonoBehaviour {

    public GameObject eToInteract;
    public List<GameObject> powerbar = new List<GameObject>();

    private GameManager manager;

    private void Start() {
        manager = FindObjectOfType<GameManager>();
    }

    void OnTriggerStay(Collider other) {
        if (other.transform.CompareTag("Player")) {
            eToInteract.SetActive(true);
            if (Input.GetKeyDown("e")) {
                eToInteract.SetActive(false);
                powerbar[0].SetActive(false);   // sets the first item in the list inactive.
                powerbar.RemoveAt(0);           // then completely removes it.

                if (manager.currentPlanetSlate == manager.planetPosPaper1) manager.currentPlanetSlate = manager.planetPosPaper2;
                else if (manager.currentPlanetSlate == manager.planetPosPaper2) manager.currentPlanetSlate = manager.planetPosPaper3;
                else if (manager.currentPlanetSlate == manager.planetPosPaper3) manager.currentPlanetSlate = manager.planetPosPaper4;

                this.transform.gameObject.SetActive(false);           // lastly, disable game component.
            }
        }
    }
}
