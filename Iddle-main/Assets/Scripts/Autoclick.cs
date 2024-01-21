using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Autoclick : MonoBehaviour
{

    public ScoreManager scoreManager;
    public int clickPower;
    public float timeBetClick = 1;

    void Start()
    {
        clickPower = 1;
        
    }
    
    private IEnumerator AutoClicker()
    {
        while (true)
        {
            scoreManager.RiseScore(clickPower);
            yield return new WaitForSeconds(timeBetClick);
        }
    }
    public void Upgrade()
    {
        scoreManager.buy();
    }
    public void LaunchAuto()
    {
        StartCoroutine(AutoClicker());
    }
}
