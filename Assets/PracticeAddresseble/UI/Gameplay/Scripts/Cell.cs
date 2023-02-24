using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Cell : MonoBehaviour
{
    public int ID;
    [SerializeField] private Image _iconCell;
    private Coroutine _openCellCoroutine;

    public void CreateCell(int id, Sprite icon)
    {
        ID = id;
        _iconCell.sprite = icon;
    }

    public void OnClick_Cell()
    {
        _openCellCoroutine = StartCoroutine(OpenCell());
    }

    public void CloseCell()
    {
        StopCoroutine(_openCellCoroutine);
        _iconCell.enabled = false;
    }

    private IEnumerator OpenCell()
    {
        _iconCell.enabled = true;
        yield return new WaitForSeconds(2);
        _iconCell.enabled = false;
    }
}
