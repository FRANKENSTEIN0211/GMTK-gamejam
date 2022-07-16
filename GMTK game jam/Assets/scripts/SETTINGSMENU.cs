using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine;

public class SETTINGSMENU : MonoBehaviour
{
    public AudioMixer mainmixer;
    public void setvolume(float volume)
    {
        mainmixer.SetFloat("volume", volume);
    }
    public void SETFULLSCREEN(bool isfullscreen)
    {
        Screen.fullScreen = isfullscreen;
    }
}
