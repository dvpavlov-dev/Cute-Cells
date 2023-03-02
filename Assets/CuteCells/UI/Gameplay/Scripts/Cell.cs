using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class Cell : MonoBehaviour
{
    public int ID;
    [SerializeField] private Image _iconCell;
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private AudioClip _openClip;
    private CellsZone _cellsZone;

    public void CreateCell(int id, Sprite icon, CellsZone cellsZone)
    {
        ID = id;
        _iconCell.sprite = icon;
        _cellsZone = cellsZone;
        transform.localScale = Vector3.zero;
        transform.DOScale(1, 1).SetEase(Ease.OutBounce);
    }

    public void OnClick_Cell()
    {
        if (_cellsZone.IsBlockedOpening)
            return;

        _iconCell.enabled = true;
        _audioSource.clip = _openClip;
        _audioSource.Play();
        _cellsZone.CheckCountOpenCells(this);
    }

    public void CloseCell()
    {
        StartCoroutine(CloseCellDelay());
    }

    public void ShakeCellAnimation()
    {
        transform.DOShakeScale(0.5f, new Vector3(0.1f, 0.1f, 0.1f));
    }

    public void DestroyCell()
    {
        StartCoroutine(DestroyCellDelay());
    }

    private IEnumerator CloseCellDelay()
    {
        transform.DOShakeScale(0.5f, new Vector3(0.1f, 0.1f, 0.1f));
        yield return new WaitForSeconds(1);
        _iconCell.enabled = false;
    }

    private IEnumerator DestroyCellDelay()
    {
        transform.DORotate(new Vector3(0, 0, 180), 1);
        transform.DOScale(0, 1);
        yield return new WaitForSeconds(1);
        Destroy(gameObject);
    }
}
