using System;
using System.Collections;
using UnityEngine;

public class CellsZone : MonoBehaviour
{
    public Action OnAllCellsDestroy;
    [SerializeField] private Cell[] _cells;
    [SerializeField] private Sprite[] _sprites;
    public bool IsBlockedOpening;
    private int _cellsCount;
    private System.Random rand = new System.Random();
    private Cell[] _openedCells;
    private int _countOpenCells = 0;

    public void InitCells()
    {
        _openedCells = new Cell[2];

        for (int i = _cells.Length - 1; i >= 1; i--)
        {
            int j = rand.Next(i + 1);
            var temp = _cells[j];
            _cells[j] = _cells[i];
            _cells[i] = temp;
        }

        for (int i = 0; i < _cells.Length; i++)
        {
            _cells[i].CreateCell(i / 2, _sprites[i / 2], this);
        }

        _cellsCount = _cells.Length;
    }

    private void CountCells()
    {
        if(_cellsCount <= 0)
        {
            OnAllCellsDestroy?.Invoke();
        }
    }

    private void CheckCellSimilatiry()
    {
        IsBlockedOpening = true;
        if (_openedCells[0].ID == _openedCells[1].ID)
        {
            _openedCells[0].DestroyCell();
            _openedCells[0] = null;
            _openedCells[1].DestroyCell();
            _openedCells[1] = null;

            _cellsCount -= 2;
            CountCells();
        }
        else
        {
            _openedCells[0]?.CloseCell();
            _openedCells[1]?.CloseCell();
        }

        StartCoroutine(UnlockingOpening());
    }

    private IEnumerator UnlockingOpening()
    {
        yield return new WaitForSeconds(1);
        IsBlockedOpening = false;
    }

    public void CheckCountOpenCells(Cell cell)
    {
        if(_countOpenCells == 0)
        {
            _openedCells[_countOpenCells] = cell;
            _countOpenCells++;
        }

        if (_countOpenCells == 1 && _openedCells[0] != cell)
        {
            _openedCells[_countOpenCells] = cell;
            CheckCellSimilatiry();
            _countOpenCells = 0;
        }
    }
}
