using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    [SerializeField] CellsZone CellsZ;

    void Start()
    {
        StartLevel();
        CellsZ.OnAllCellsDestroy += GameOver;
    }

    private void ChangeLevel()
    {

    }

    private void GameOver()
    {

    }

    private void StartLevel()
    {
        CellsZ.InitCells();
    }
}
