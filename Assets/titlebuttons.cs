using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class titlebuttons : MonoBehaviour
{

    public void ClickOnStart()
    {
        Gamemanager.Instance.OnClickStart();
    }

    public void ClickOnNewGame()
    {
        Wizard.stats = new PlayerStats();
        Gamemanager.Instance.OnClickStart();
    }

    public void ClickExit()
    {
        Application.Quit();
    }

}
