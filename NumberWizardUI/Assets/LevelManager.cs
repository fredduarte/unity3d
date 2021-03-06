using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

    public void LoadLevel(string name) {
        Debug.Log("Level Load requested for " + name);
        Application.LoadLevel(name);
    }

    public void QuitRequest() {
        Debug.Log("I want to Quit!");
        Application.Quit();
    }
}
