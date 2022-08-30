using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public GameObject canvas;
    private float tiempo = 3.5f;
    void Update()
    {
        tiempo = tiempo - 1 * Time.deltaTime;

        
        if (tiempo < 1.5f)
        {
            canvas.SetActive(false);
        }


        if (tiempo < 1f)
        {
            SceneManager.LoadScene(1);
        }
    }
}
