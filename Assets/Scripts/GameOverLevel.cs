using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverLevel : MonoBehaviour {

	public void LoadScene(string name)
    {
        Application.LoadLevel("PrideRock");
    }

    public void LoadMenu(string name)
    {
        Application.LoadLevel("MainMenu");

    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void MouseReappear()
    {
        Cursor.visible = true;
    }
}
