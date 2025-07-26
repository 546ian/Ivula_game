using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public GameObject music;

    public AudioMixer audioMixer;

    public Slider musicSlider;
    public Slider sfxSlider;

    public void Start()
    {
        LoadVolume();  
        // Play the main menu music
        MusicManager.Instance.PlayMusic("Main Menu");
    }

    public void PlayGame()
    {
        // Load the game scene
        LevelManager.Instance.LoadScene("Gameplay", "CrossFade");

        music.SetActive(false);
    }

    public void QuitGame()
    {
        // Quit the application
        Application.Quit();

        // If running in the editor, log a message
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }

    public void UpdateMusicVolume(float volume)
    {
        // Update the music volume in the audio mixer
        audioMixer.SetFloat("MusicVolume", volume);
    }

    public void UpdateSFXVolume(float volume)
    {
        // Update the sound effects volume in the audio mixer
        audioMixer.SetFloat("SFXVolume", volume);
    }

    public void SaveVolume()
    {
        audioMixer.GetFloat("MusicVolume", out float musicVolume);
        PlayerPrefs.SetFloat("MusicVolume", musicVolume);

        audioMixer.GetFloat("SFXVolume", out float sfxVolume);
        PlayerPrefs.SetFloat("SFXVolume", sfxVolume);
    }

    public void LoadVolume()
    {
        musicSlider.value = PlayerPrefs.GetFloat("MusicVolume"); 
        sfxSlider.value = PlayerPrefs.GetFloat("SFXVolume");
    }
}
