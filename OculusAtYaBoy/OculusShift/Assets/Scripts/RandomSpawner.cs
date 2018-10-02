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
            SpawnTarget();
        }
    }

    public void SpawnTarget()
    {
        randomTarget = Random.Range(1, 3);
        randomSpawnPoint = Random.Range(0, 12);

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
        if(randomSpawnPoint == 0 || randomSpawnPoint == 1 || randomSpawnPoint == 2)
        {
            targey.GetComponent<Target>().moveDirection = Target.MoveDirection.down;
        }
        if (randomSpawnPoint == 3 || randomSpawnPoint == 4 || randomSpawnPoint == 5)
        {
            targey.GetComponent<Target>().moveDirection = Target.MoveDirection.left;
        }
        if (randomSpawnPoint == 6 || randomSpawnPoint == 7 || randomSpawnPoint == 8)
        {
            targey.GetComponent<Target>().moveDirection = Target.MoveDirection.up;
        }
        if (randomSpawnPoint == 9 || randomSpawnPoint == 10 || randomSpawnPoint == 11)
        {
            targey.GetComponent<Target>().moveDirection = Target.MoveDirection.right;
        }
    }
}