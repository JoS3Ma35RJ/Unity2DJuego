using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BotonJugar : MonoBehaviour
{
    private Button btn;
    private string scene;

    void Start()
    {
        scene = "EscenaJuego";
        btn = GetComponent<Button>();
        btn.onClick.AddListener(Jugar);
    }

    private void Jugar()
    {
        SceneManager.LoadScene(scene);
    }
}
