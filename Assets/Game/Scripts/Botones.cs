using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Botones : MonoBehaviour
{
    public void Salir()
    {
        Application.Quit();
    }

    public void Jugar(string nombre)
    {
        SceneManager.LoadScene(nombre);
    }
    public void Borra()
    {
        PlayerPrefs.DeleteAll();
    }
}
