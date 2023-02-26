using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class UIStartMenu : MonoBehaviour
{
    [SerializeField] private GameObject _startPanel;
    [SerializeField] private AudioSource _audioSource;

    public void StartGame()
    {
        _audioSource.Play();
        _startPanel.transform.DOScale(0, 1);
        Invoke(nameof(ChangeLevel), 1);
    }

    public void Levels()
    {
        _audioSource.Play();
    }

    public void Exit()
    {
        _audioSource.Play();
        Application.Quit();
    }

    private void ChangeLevel()
    {
        SceneManager.LoadScene("Level 1");
    }
}
