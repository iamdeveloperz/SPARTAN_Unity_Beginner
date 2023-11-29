using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    #region Variables_Managers

    private UIManager _uiManager = new();
    private DataManager _dataManager = new();

    #endregion




    #region Variables_GameData

    #endregion




    #region Properties

    public UIManager UI => Instance._uiManager;
    public DataManager Data => Instance._dataManager;

    #endregion


    private void Awake()
    {
        Data.Initalize();
    }
}