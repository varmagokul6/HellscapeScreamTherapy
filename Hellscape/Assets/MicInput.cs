using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class MicInput : MonoBehaviour
{
    #region SingleTon
 
    public static MicInput Instance { set; get; }
    
    #endregion
    public bool isInitialized; 
    public static float MicFinal;
 
    private string device;
    
    AudioClip clipRecord;
    AudioClip _recordedClip;
    int sampleWindow = 128;

    //mic initialization
    public void InitMic()
    {
        if (device == null)
        {
            device = Microphone.devices[0];
        }
        clipRecord = Microphone.Start(device, true, 999, 44100);
        isInitialized = true;
    }
 
    public void StopMicrophone()
    {
        Microphone.End(device);
        isInitialized = false;
    }
 
 
    //get data from microphone into audioclip
    float RecordedVolume()
    {
        float levelMax = 0;
        float[] waveData = new float[sampleWindow];
        int micPosition = Microphone.GetPosition(null) - (sampleWindow + 1); // null means the first microphone
        if (micPosition < 0){
            return 0;
        }
        
        clipRecord.GetData(waveData, micPosition);
        // Getting a peak on the last 128 samples
        for (int i = 0; i < sampleWindow; i++)
        {
            float wavePeak = waveData[i] * waveData[i];
            if (levelMax < wavePeak)
            {
                levelMax = wavePeak;
            }
        }
        return levelMax;
    }
 
 
    void Update()
    {
        // levelMax equals to the highest normalized value power 2, a small number because < 1
        // pass the value to a static var so we can access it from anywhere
        MicFinal = RecordedVolume();
    }
    void OnEnable()
        {
            InitMic();
            isInitialized=true;
        }
}