using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RealtimeTimer : MonoBehaviour
{
    private Text timeText;

    private void Start()
    {
        timeText = GetComponent<Text>();

        StartCoroutine(UpdateTime());
    }

    IEnumerator UpdateTime()
    {
        while(true)
        {
            timeText.text = CoreUtilities.GetCurrentDate();
            yield return new WaitForSecondsRealtime(1);
        }
    }
}
