using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverLevel : MonoBehaviour {

    public int score;
    public int ScoreX, ScoreY;

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

    private void OnGUI()
    {
        GUI.Label(new Rect(ScoreX, ScoreY, 100, 20), "Final Score:" + score.ToString());
    }

    public void MouseReappear()
    {
        Cursor.visible = true;
    }
}
