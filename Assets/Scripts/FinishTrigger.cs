using UnityEngine;

public class FinishTrigger : MonoBehaviour
{

    public GameManager gm;

    void OnTriggerEnter()
    {
        gm.CompleteLevel();
    }
}
