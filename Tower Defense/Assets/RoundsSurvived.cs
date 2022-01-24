using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoundsSurvived : MonoBehaviour
{
    public Text roundText;
    
    private void OnEnable()
    {
        StartCoroutine(AnimateText());
    }
    private IEnumerator AnimateText()
    {
        roundText.text = "0";
        int _round = 0;

        yield return new WaitForSeconds(0.7f);

        while (_round < PlayerStats.Rounds)
        {
            _round++;
            roundText.text = _round.ToString();

            yield return new WaitForSeconds(0.05f);
        }
    }
}
