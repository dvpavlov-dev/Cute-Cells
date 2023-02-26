using UnityEngine;

public class LevelController : MonoBehaviour
{
    [SerializeField] private CellsZone CellsZ;
    [SerializeField] private UI UIGameplay;

    void Start()
    {
        StartLevel();
        CellsZ.OnAllCellsDestroy += GameWin;
    }

    public void ChangeLevel()
    {
        //TODO: сюда добавить Addressable
    }

    public void BackToMenu()
    {
        //TODO: возвращение на стартовое меню
    }

    private void GameWin()
    {
        UIGameplay.GameWin();
    }

    private void StartLevel()
    {
        CellsZ.InitCells();
    }
}
