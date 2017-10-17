using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_Manager : MonoBehaviour
{
    //Variables
    public VoiceOutput VoiceOut;


    void Start()
    {

    }


    void Update()
    {

    }

    public void TEMP_VoiceOutputTesting(string output)
    {
        VoiceOut.PlayVoiceOutput(output);
    }
}
