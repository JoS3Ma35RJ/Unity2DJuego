using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PausePanel : MonoBehaviour
{
    public static bool isPaused = false;
    public GameObject pausePanel;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                ResumeGame();
            }
            else
                PauseGame();
        }
    }

    public void PauseGame()
    {
        //Actualizamos a pausado y cambiamos a 0 la "velocidad" del juego
        isPaused = true;
        Time.timeScale = 0f;
        
        //Pausamos la música
        AudioListener.pause = true;

        //Buscamos el objeto PausePanel por tag si no está asignado
        if (pausePanel == null)
        {
            pausePanel = GameObject.FindGameObjectWithTag("PausePanel");
        }

        //Mostramos el panel de pausa si se encontró el objeto
        if (pausePanel != null)
        {
            pausePanel.SetActive(true);
        }
    }

    public void ResumeGame()
    {
        //Reanuda la partida
        isPaused = false;
        Time.timeScale = GameManager.fastForwardTimeScale;

        //Activa la música
        AudioListener.pause = false;

        //Buscamos el objeto PausePanel por tag si no está asignado
        if (pausePanel == null)
        {
            pausePanel = GameObject.FindGameObjectWithTag("PausePanel");
        }

        //Desactiva el panel de pausa si se encontró el objeto
        if (pausePanel != null)
        {
            pausePanel.SetActive(false);
        }
    }
}