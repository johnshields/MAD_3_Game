﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResOptions : MonoBehaviour
{

    void Update()
    {
       
    }

    public void SetResolution()
    {
        SetScreenRes();
    }

    void SetScreenRes()
    {
        // 648, 720, 1080
        // getting the name of what we pressed
        string index = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;

        // change the resolution of the game
        switch(index)
        {
            case "658":
                Screen.SetResolution(1152, 648, true);
                break;
            case "720":
                Screen.SetResolution(1360, 796, true);
                break;
            case "1080":
                Screen.SetResolution(1980, 1080, true);
                break;
            case "DEFAULT":
                Screen.SetResolution(1980, 1080, true);
                break;
        }
    }

    // save setting and return to options
    public void SAVEandReturn()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainOptions");
        AudioListener.volume = 1f;
    }
}
