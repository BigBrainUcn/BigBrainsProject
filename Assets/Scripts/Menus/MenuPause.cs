using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPause : MonoBehaviour
{

    

    [SerializeField] private GameObject menuPause;

    private bool juegoPausado = false;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(juegoPausado)
            {
                Resume();
            }
            else
            {
                Pause();
            }    
        }
   }

   public void Pause ()
   {

    Time.timeScale = 0f;
    menuPause.SetActive(true);

   }

   public void Resume ()
   {
    
    Time.timeScale = 1f;
    menuPause.SetActive(false);

   }
   public void Reiniciar (){
    Time.timeScale = 1f;
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);

   }
   public void Cerrar (){
    Debug.Log("Quit game");
    Application.Quit();
   }
}
