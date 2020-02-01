using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountdownTimer : MonoBehaviour
{
    float currCountdownVal ;
    public GameObject player;
    Vector3 originalPosition;
    
    private int iteration = 0;
    private IEnumerator StartCountdown(float countDownValue=20.0f)
    {
        currCountdownVal = countDownValue;
        while(currCountdownVal>0)
        {
            Debug.Log("TimeLeft:" + currCountdownVal);
            yield return new WaitForSeconds(1.0f);
            currCountdownVal--;
        }
        player.transform.position = originalPosition;
        
        iteration++;
        Start();
        
    }

    void Start()
    {
        
        Debug.Log("Iteration." + iteration);
        originalPosition = player.transform.position;
        StartCoroutine(StartCountdown());
        
        

    }
}
