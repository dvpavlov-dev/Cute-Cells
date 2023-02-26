using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    public GameObject GameplayPanel;
    public GameObject WinBackground;

    public void GameWin()
    {
        GameplayPanel.SetActive(false);
        WinBackground.SetActive(true);
    }
}
