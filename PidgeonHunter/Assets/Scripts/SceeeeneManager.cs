using UnityEngine;
using UnityEngine.SceneManagement;

public class SceeeeneManager : MonoBehaviour
{
    public GameObject deathCanvas; 

    public void Update ()
    {
        if (deathCanvas.activeInHierarchy && Input.GetKey(KeyCode.R) )
        {
            SceneManager.LoadScene(0);
        }
    }


    public void SceneLoader(int SceneIndex)
    {
        SceneManager.LoadScene(SceneIndex);
    }

    public void QuitGame()
    {
#if UNITY_EDITOR

        UnityEditor.EditorApplication.isPlaying = false;

#else

        Application.Quit();

#endif
    }
}
