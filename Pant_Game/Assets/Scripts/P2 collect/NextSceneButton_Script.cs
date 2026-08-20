using UnityEngine;
using UnityEngine.SceneManagement;

public class NextSceneButton_Script : MonoBehaviour
{
    public void LoadNextScene()
    {
        SceneManager.LoadScene(0);
        Cursor.visible = true;
    }
}
