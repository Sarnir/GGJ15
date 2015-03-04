using UnityEngine;
using System.Collections;

public class ToggleSoundButton : MonoBehaviour
{
    void Start()
    {
        SetMusicEnabled(PlayerPrefs.GetInt("MusicEnabled", 1) > 0);
    }

    void OnMouseUp()
    {
        SetMusicEnabled(!IsMusicEnabled());
    }

    void SetMusicEnabled(bool val)
    {
        AudioListener.pause = !val;
        AudioListener.volume = val ? 1.0f : 0.0f;
        PlayerPrefs.SetInt("MusicEnabled", val ? 1 : 0);
    }

    bool IsMusicEnabled()
    {
        return !AudioListener.pause;
    }
}