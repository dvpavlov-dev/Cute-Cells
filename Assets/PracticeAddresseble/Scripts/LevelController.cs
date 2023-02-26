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
        //TODO: ���� �������� Addressable
    }

    public void BackToMenu()
    {
        //TODO: ����������� �� ��������� ����
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
