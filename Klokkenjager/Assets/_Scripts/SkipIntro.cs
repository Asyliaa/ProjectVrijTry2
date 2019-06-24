using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class SkipIntro : MonoBehaviour {

    public VideoPlayer vid;
    public Text eToSkip;

    void Start() {
        eToSkip.text = "Press E to skip.";
        vid.loopPointReached += CheckOver;
    }

    private void Update() {
        if (Input.GetKeyDown("e")) {
            eToSkip.text = "Loading...";
            SceneManager.LoadScene(2);
        }
    }

    void CheckOver(UnityEngine.Video.VideoPlayer vp) {
        eToSkip.text = "Press E to start.";

        if (Input.GetKeyDown("e")) {
            eToSkip.text = "Loading...";
            SceneManager.LoadScene(2);
        }
    }

}