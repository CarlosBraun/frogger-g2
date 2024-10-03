using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    // Método que se ejecuta al hacer clic en el botón
    public void PlayGameEasy()
    {
        // Asegúrate de poner el nombre correcto de la escena del juego aquí
        SceneManager.LoadScene("Frogger_Easy");
    }
    public void PlayGameNormal()
    {
        // Asegúrate de poner el nombre correcto de la escena del juego aquí
        SceneManager.LoadScene("Frogger_Normal");
    }
    public void PlayGameHard()
    {
        // Asegúrate de poner el nombre correcto de la escena del juego aquí
        SceneManager.LoadScene("Frogger_Dificil");
    }

    // Método para salir del juego
    public void QuitGame()
    {
        Debug.Log("Saliendo del juego...");
        Application.Quit(); // Solo funciona en una build, no en el editor.
    }
}
