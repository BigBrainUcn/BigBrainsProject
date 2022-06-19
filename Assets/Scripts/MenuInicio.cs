using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;

public class MenuInicio : MonoBehaviour
{

    [Header("Options")]
    public Slider volume;
    public Slider Brightness;
    public AudioMixer mixer;
    public AudioSource source;
    public AudioClip clickSound;
    [Header("Panels")]
    public GameObject MenuInicioPanel;
    public GameObject OptionsPanel;

    private void Awake(){
        volume.onValueChanged.AddListener(ChangeVolume);

    }

    public void OpenPanel(GameObject panel){
        MenuInicioPanel.SetActive(false);
        OptionsPanel.SetActive(false);
        panel.SetActive(true);

    }
    public void ChangeVolume(float v){
        mixer.SetFloat("Volume", v);
    }
    public void PlaySoundButton(){
        source.PlayOneShot(clickSound);
    }


    public void Jugar(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Salir(){
        Debug.Log("Salir");
        Application.Quit();
    }
}
