using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickHandler : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void StartGameLevel()
    {
        Application.LoadLevel("Terrain");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
