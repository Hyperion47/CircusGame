using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour {

    public List<GameObject> targets;

    public int randomTarget;
    public int randomSpawnPoint;

    public List<Transform> Spawns;

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
        randomTarget = Random.Range(1, 3);
        randomSpawnPoint = Random.Range(0, 4);

        GameObject targey;

        if (randomTarget == 1)
        {
            targey = Instantiate(targets[0], Spawns[randomSpawnPoint]);
            SpawnChecks(targey);
        }
        if (randomTarget == 2)
        {
            targey = Instantiate(targets[1], Spawns[randomSpawnPoint]);
            SpawnChecks(targey);
        }
    }

    public void SpawnChecks(GameObject targey)
    {
        if(randomSpawnPoint == 0)
        {
            targey.GetComponent<Target>().moveDirection = Target.MoveDirection.down;
        }
        if (randomSpawnPoint == 1)
        {
            targey.GetComponent<Target>().moveDirection = Target.MoveDirection.left;
        }
        if (randomSpawnPoint == 2)
        {
            targey.GetComponent<Target>().moveDirection = Target.MoveDirection.up;
        }
        if (randomSpawnPoint == 3)
        {
            targey.GetComponent<Target>().moveDirection = Target.MoveDirection.right;
        }
    }
}