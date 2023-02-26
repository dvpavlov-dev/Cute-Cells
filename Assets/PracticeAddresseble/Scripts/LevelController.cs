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

    public async Task ChangeLevelAsync()
    {
        GameContriller.LevelID++;
        var asyncOperationHandle = Addressables.LoadSceneAsync($"Level {GameContriller.LevelID}", LoadSceneMode.Additive);
        await asyncOperationHandle.Task;
        //TODO: сюда добавить Addressable
        //GameContriller.LevelID++;
        //SceneManager.LoadScene($"Level {GameContriller.LevelID}");
    }

    public void BackToMenu()
    {
        //TODO: возвращение на стартовое меню
        SceneManager.LoadScene("Start menu");
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
