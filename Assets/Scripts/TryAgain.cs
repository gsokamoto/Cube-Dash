using UnityEngine;
using UnityEngine.SceneManagement;

public class TryAgain : MonoBehaviour
{

    public void RestartAttempt()
    {
        SceneManager.LoadScene(1);
    }

}