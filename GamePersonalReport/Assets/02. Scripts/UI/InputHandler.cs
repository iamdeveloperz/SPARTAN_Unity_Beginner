using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InputHandler : MonoBehaviour
{
    private InputField _nameInputField;

    private void Start()
    {
        _nameInputField = GetComponent<InputField>();
    }

    public void SubmitName()
    {
        string userName = _nameInputField.text;

        if (userName.Length >= 2 && userName.Length <= 10)
        {
            PlayerPrefs.SetString(CoreUtilities.PLAYER_KEY, userName);
            SceneManager.LoadScene("MainGame");
        }
        else
            _nameInputField.text = "다시 입력 해주세요";
    }
}