using UnityEngine;
using UnityEngine.SceneManagement;

public class CollectScene_Script : MonoBehaviour
{
    public void LoadNextScene()
    {
        SceneManager.LoadScene(1);
    }
}
