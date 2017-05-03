using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour {

    public Transform mainMenu, instructionsMenu, preferencesMenu;
    bool muted;
    [SerializeField]
    Text mutetext;

    public void LoadScene(string name)
    {
        Application.LoadLevel("PrideRock");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void InstructionsMenu (bool clicked)
    {
        if(clicked == true)
        {
            instructionsMenu.gameObject.SetActive(clicked);
            mainMenu.gameObject.SetActive(false);
        }else
        {
            instructionsMenu.gameObject.SetActive(clicked);
            mainMenu.gameObject.SetActive(true);
        }

    }
    
    public void Mute()
    {
        muted = !muted;
    }

   void Update()
    {
        if (muted)
        {
            AudioListener.volume = 0;
            mutetext.text = "Unmute";
        }
        else if (!muted)
        {
            AudioListener.volume = 1;
            mutetext.text = "Mute";
        }
    }
    
}
