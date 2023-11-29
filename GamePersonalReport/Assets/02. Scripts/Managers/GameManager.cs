using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region Variables_Managers
    private UIManager _uiManager = new();
    #endregion




    #region Variables_GameData

    #endregion




    #region Properties
    public UIManager UI => _uiManager;
    #endregion
}