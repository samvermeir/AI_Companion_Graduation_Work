using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SpeechLib;

public class VoiceOutput : MonoBehaviour
{
    //Public Variables
    [Range(0, 100)]
    public int Volume = 100;
    [Range(0, 100)]
    public int Rate = 0;
    public string OutputText;
    public bool PlayVoiceOutputBool = false;

    //Private Variables
    private SpVoice voice;

    //Methods
    void Start()
    {
        voice = new SpVoice();
    }

    void Update()
    {
        if (PlayVoiceOutputBool)
        {
            //play the voice output
            voice.Volume = Volume;
            voice.Rate = Rate;
            voice.Speak(OutputText, SpeechVoiceSpeakFlags.SVSFlagsAsync);


            //reset the bool
            PlayVoiceOutputBool = false;
        }
    }

    public void PlayVoiceOutput()
    {
        PlayVoiceOutputBool = true;
    }
    public void SetOutputText(string text)
    {
        OutputText = text;
    }
    public void SetVolume(int volume)
    {
        Volume = volume;
    }
    public void SetRate(int rate)
    {
        Rate = rate;
    }
    public void LowerVolume()
    {
        Volume -= 10;
        if (Volume<0)
        {
            Volume = 0;
        }
    }
    public void HigherVolume()
    {
        Volume += 10;
        if (Volume > 100)
        {
            Volume = 100;
        }
    }
}
