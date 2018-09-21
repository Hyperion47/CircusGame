using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour {

    public GameObject Target1;
    public GameObject Target2;
    public GameObject Target3;
    public GameObject Target4;

    public int randomTarget;
    public int randomSpawnPoint;

    public Transform SpawnTest;

    private void Start()
    {
        StartCoroutine(ActivateOnTimer());
    }

    IEnumerator ActivateOnTimer()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            //stuff that happens every second happens here:
            SpawnTarget();
        }
    }

    public void SpawnTarget()
    {
        randomTarget = Random.Range(1, 5);
        if (randomTarget == 1)
        {
            Instantiate(Target1, SpawnTest);
        }
        if (randomTarget == 2)
        {
            Instantiate(Target2, SpawnTest);
        }
        if (randomTarget == 3)
        {
            Instantiate(Target3, SpawnTest);
        }
        if (randomTarget == 4)
        {
            Instantiate(Target4, SpawnTest);
        }
    }
}
