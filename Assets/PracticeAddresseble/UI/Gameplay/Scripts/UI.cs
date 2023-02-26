using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class UI : MonoBehaviour
{
    public GameObject GameplayPanel;
    public GameObject WinBackground;
    private Sequence _seq;

    public void GameWin()
    {
        //GameplayPanel.transform.DOScale(0, 1);
        ////GameplayPanel.SetActive(false);
        //WinBackground.transform.localScale = Vector3.zero;
        //WinBackground.transform.DOScale(1, 1);
        //WinBackground.SetActive(true);

        _seq = DOTween.Sequence();
        _seq.Append(GameplayPanel.transform.DOScale(0, 1));
        _seq.Append(WinBackground.transform.DOScale(1, 1));
    }
}
