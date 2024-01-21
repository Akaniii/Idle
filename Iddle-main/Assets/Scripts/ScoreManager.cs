using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    public int FloopyDisk;
    public int CostOfUpgrade = 10 ;
    public TextMeshProUGUI scoreText;
    public Autoclick autoclick;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (FloopyDisk<0)
        {
            FloopyDisk = 0;
        }
    }

    public void RiseScore(int click)
    {
        FloopyDisk += click;
        scoreText.text = FloopyDisk.ToString("0000");
    }
     
    
    public void buy ()
    {
        if (CostOfUpgrade == 10)
        {
            autoclick.LaunchAuto();
            
        }
        
        if(CostOfUpgrade<=FloopyDisk)
        {
            FloopyDisk =- CostOfUpgrade;
            
            autoclick.clickPower++;
            CostOfUpgrade += 10;
        }
    }
}
