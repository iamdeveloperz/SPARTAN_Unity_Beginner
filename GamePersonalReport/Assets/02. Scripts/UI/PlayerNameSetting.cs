using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerNameSetting : MonoBehaviour
{
    private Text _textPlayerName;

    private void Start()
    {
        _textPlayerName = GetComponentInChildren<Text>();

        _textPlayerName.text = GameManager.Instance.Data.PlayerName;
    }
}
