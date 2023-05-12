using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static int LevelID;

    private void Start()
    {
        DontDestroyOnLoad(this);
        LevelID = 1;
    }
}
