using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public GameObject solarPuzzleEighties;
    public GameObject solarPuzzleMedieval;

    public GameObject solarSolutionEighties;
    public GameObject solarSolutionMedieval;

    public GameObject letter;
    public GameObject planetPosPaper1;
    public GameObject planetPosPaper2;
    public GameObject planetPosPaper3;
    public GameObject planetPosPaper4;

    public GameObject currentPlanetSlate;

    public static bool victorianPuzzleComplete;


    // Start is called before the first frame update
    void Start() {
        currentPlanetSlate = planetPosPaper1;

        letter.SetActive(true);
        planetPosPaper1.SetActive(true);
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Escape)){
            if (letter != null && planetPosPaper1 != null) {
                Destroy(letter);
                planetPosPaper1.SetActive(false);
            }
        }

        if (Input.GetKeyDown("p") && currentPlanetSlate.activeInHierarchy) {
            currentPlanetSlate.SetActive(false);
        }
        else if (Input.GetKeyDown("p") && !currentPlanetSlate.activeInHierarchy) {
            currentPlanetSlate.SetActive(true);
        }

        if (victorianPuzzleComplete) {
            Debug.Log("LAST PUZZLE COMPLETE!");
        }

    }
}
