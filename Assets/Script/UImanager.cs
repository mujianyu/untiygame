using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class UImanager : MonoBehaviour
{
    public AudioSource music;
    public Slider slider;
    private void Start()
    {
        music.volume = PlayerPrefs.GetFloat("Volume");//保存上一次音量大小
        slider.value = music.volume;
    }

    public void OnClick()
    {
        SceneManager.LoadScene("Game");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
    public void sound()
    {
        music.volume = slider.value;
        PlayerPrefs.SetFloat("Volume", slider.value);
    }
    
}
