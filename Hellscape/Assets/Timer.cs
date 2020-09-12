using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    // Start is called before the first frame update
    public float remainingTime = 15f;
    public bool timeFlag = false;
    
    public void Start()
    {
        timeFlag = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeFlag == true){
            if (remainingTime > 0f){
                remainingTime -= Time.deltaTime;
            }else{
                resetTimer();
            }

        }
    }
    void resetTimer(){
        remainingTime = 0f;
        timeFlag = false;
        Debug.Log("You are Out Of Time!!!");
    }
}
