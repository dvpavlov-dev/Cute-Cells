using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    [SerializeField] private CellsZone CellsZ;
    [SerializeField] private UI UIGameplay;
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private AudioClip _backgroundClip;
    [SerializeField] private AudioClip _winClip;

    void Start()
    {
        StartLevel();
        CellsZ.OnAllCellsDestroy += GameWin;
    }

    public void BackToMenu()
    {
        GameController.LevelID = 1;
        SceneManager.LoadScene("Start menu");
    }

    public void ChangeLevel()
    {
        ChangeLevelAsync();
    }

    private async Task ChangeLevelAsync()
    {
        GameController.LevelID++;
        var asyncOperationHandle = Addressables.LoadSceneAsync($"Level {GameController.LevelID}");
        await asyncOperationHandle.Task;
    }

    private void GameWin()
    {
        _audioSource.clip = _winClip;
        _audioSource.loop = false;
        _audioSource.Play();
        UIGameplay.GameWin();
    }

    private void StartLevel()
    {
        _audioSource.clip = _backgroundClip;
        _audioSource.Play();
        CellsZ.InitCells();
    }
}
