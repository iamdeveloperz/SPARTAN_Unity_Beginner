using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager
{
    private string _playerName;

    public string PlayerName => _playerName;

    public void Initalize()
    {
        _playerName = PlayerPrefs.GetString(CoreUtilities.PLAYER_KEY);
    }
}