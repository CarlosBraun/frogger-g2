using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveCycle : MonoBehaviour
{
    public Vector2 direction = Vector2.right;
    public float speed = 1f;
    public int size = 1;

    private Vector3 leftEdge;
    private Vector3 rightEdge;

    private void Start()
    {
        leftEdge = Camera.main.ViewportToWorldPoint(Vector3.zero);
        rightEdge = Camera.main.ViewportToWorldPoint(Vector3.right);

        // Obtener el nombre de la escena actual
        string sceneName = SceneManager.GetActiveScene().name;

        // Ajustar la velocidad en función del nombre de la escena
        switch (sceneName)
        {
            case "Frogger_Easy":
                speed = 0.8f; // Velocidad más baja
                break;
            case "Frogger_Normal":
                speed = 1f; // Velocidad media
                break;
            case "Frogger_Dificil":
                speed = 3f; // Velocidad más alta
                break;
            default:
                speed = 1f; // Velocidad por defecto si la escena no coincide
                break;
        }
    }

    private void Update()
    {
        // Check if the object is past the right edge of the screen
        if (direction.x > 0 && (transform.position.x - size) > rightEdge.x)
        {
            transform.position = new Vector3(leftEdge.x - size, transform.position.y, transform.position.z);
        }
        // Check if the object is past the left edge of the screen
        else if (direction.x < 0 && (transform.position.x + size) < leftEdge.x)
        {
            transform.position = new Vector3(rightEdge.x + size, transform.position.y, transform.position.z);
        }
        // Move the object
        else
        {
            transform.Translate(speed * Time.deltaTime * direction);
        }
    }
}
