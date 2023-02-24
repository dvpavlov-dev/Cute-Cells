using System;
using UnityEngine;

public class CellsZone : MonoBehaviour
{
    public Action OnAllCellsDestroy;
    [SerializeField] private Cell[] _cells;
    [SerializeField] private Sprite[] _sprites;
    private int _cellsCount;
    private System.Random rand = new System.Random();

    public void InitCells()
    {
        for (int i = _cells.Length - 1; i >= 1; i--)
        {
            int j = rand.Next(i + 1);
            var temp = _cells[j];
            _cells[j] = _cells[i];
            _cells[i] = temp;
        }

        for (int i = 0; i < _cells.Length; i++)
        {
            _cells[i].CreateCell(i / 2, _sprites[i / 2]);
        }
    }

    private void CountCells()
    {
        if(_cellsCount == 0)
        {
            OnAllCellsDestroy?.Invoke();
        }
    }

    private void CheckCellSimilatiry()
    {

    }

    private void CheckCountOpenCells()
    {

    }
}
