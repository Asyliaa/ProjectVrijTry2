using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleManager : MonoBehaviour {

    GameManager manager;
    
    Transform EightiesRespawn;
    Transform MedievalRespawn;

    Slide slide;

    void Start() {
        manager = GameObject.Find("Game Manager").GetComponent<GameManager>();

        EightiesRespawn = GameObject.Find("80sRespawn").transform;
        MedievalRespawn = GameObject.Find("Medieval Respawn").transform;

        slide = FindObjectOfType<Slide>();
    }

    void OnTriggerEnter(Collider other) {
        // SOLAR SYSTEM PUZZLE
        if (this.name == "Planet 1 Collider" && other.name == "Planet 1"){
            PuzzleOne.planetOneInPlace = true;
            Debug.Log("Planet 1 in place");
        }

        if (this.name == "Planet 2 Collider" && other.name == "Planet 2")
            PuzzleOne.planetTwoInPlace = true;

        if (this.name == "Planet 3 Collider" && other.name == "Planet 3")
            PuzzleOne.planetThreeInPlace = true;

        if (this.name == "Planet 4 Collider" && other.name == "Planet 4")
            PuzzleOne.planetFourInPlace = true;

        // 80'S PUZZLE
        if (this.name == "box" && other.CompareTag("Player")) {
            other.transform.position = EightiesRespawn.position;
            Debug.Log("PUZZLE 1 COMPLETE");
            manager.currentPlanetSlate = manager.planetPosPaper2;
            manager.currentPlanetSlate.SetActive(true);

            manager.solarPuzzleEighties.SetActive(false);
            manager.solarSolutionEighties.SetActive(false);
            manager.solarPuzzleMedieval.SetActive(true);
            manager.solarSolutionMedieval.SetActive(true);

            slide.middleAgesTheme.Play();
        }

        if (this.name == "Slide" && other.CompareTag("Player")) {
            other.transform.position = MedievalRespawn.position;
        }

    } 

    void OnCollisionEnter(Collision other) {
        if (this.name == "Normal Tile" && other.transform.CompareTag("Player")) {
            other.transform.position = EightiesRespawn.position;
        }
    }
}
