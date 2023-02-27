using UnityEngine;
using DG.Tweening;
using UnityEngine.AddressableAssets;
using System.Threading.Tasks;

public class UIStartMenu : MonoBehaviour
{
    [SerializeField] private GameObject _startPanel;
    [SerializeField] private AudioSource _audioSource;

    public void StartGame()
    {
        _audioSource.Play();
        _startPanel.transform.DOScale(0, 1);
        Invoke(nameof(ChangeLevelAsync), 1);
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

    private async Task ChangeLevelAsync()
    {
        var asyncOperationHandle = Addressables.LoadSceneAsync($"Level 1");
        await asyncOperationHandle.Task;
    }
}
