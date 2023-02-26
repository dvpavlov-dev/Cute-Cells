using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Cell : MonoBehaviour
{
    public int ID;
    [SerializeField] private Image _iconCell;
    private Coroutine _openCellCoroutine;
    private CellsZone _cellsZone;

    public void CreateCell(int id, Sprite icon, CellsZone cellsZone)
    {
        ID = id;
        _iconCell.sprite = icon;
        _cellsZone = cellsZone;
    }

    public void OnClick_Cell()
    {
        if (_cellsZone.IsBlockedOpening)
            return;

        _iconCell.enabled = true;
        _cellsZone.CheckCountOpenCells(this);
    }

    public void CloseCell()
    {
        StartCoroutine(CloseCellDelay());
    }

    private IEnumerator CloseCellDelay()
    {
        yield return new WaitForSeconds(1);
        _iconCell.enabled = false;
    }

    public void DestroyCell()
    {
        StartCoroutine(DestroyCellDelay());
    }

    private IEnumerator DestroyCellDelay()
    {
        yield return new WaitForSeconds(1);
        Destroy(gameObject);
    }
}
