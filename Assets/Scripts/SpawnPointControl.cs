using UnityEngine;

public class SpawnPointControl : MonoBehaviour
{
    public GameObject[] spawnPoints;
 
    void Start()
    {
        deletePoint();
    }
    void deletePoint()
    {
        bool[] isBroken = new bool[spawnPoints.Length];
        for (int i = 0; i < isBroken.Length; i++)
        {
            isBroken[i] = false;
        }
        int rand;
        for(int i = 0; i < isBroken.Length; i++)
        {
            rand = Random.Range(0, 2);
            if (rand == 0)
            {
                spawnPoints[i].SetActive(false);
                isBroken[i] = true;
            }
        }
        if(isAllTrue(isBroken))
        {
            rand = Random.Range(0, 4);
            spawnPoints[rand].SetActive(true);
        }
        if(isAllFalse(isBroken))
        {
            rand = Random.Range(0, 4);
            spawnPoints[rand].SetActive(false);
        }
    }
    bool isAllTrue(bool[] Array)
    {
        for (int i = 0; i < Array.Length; i++)
        {
            if (Array[i] == false)
            {
                return false;
            }
        }
        return true;
    }

    bool isAllFalse(bool[] Array)
    {
        for (int i = 0; i < Array.Length; i++)
        {
            if (Array[i] == true)
            {
                return false;
            }
        }
        return true;
    }

}
