using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour {

    public Vector3 up;
    public Vector3 down;
    public Vector3 left;
    public Vector3 right;

    public MoveDirection moveDirection;

    public float MoveSpeed;
    public int KillTime;
    public int PointsRewarded;

    public GameObject score;

    public enum MoveDirection
    {
        up = 0,
        down = 1,
        right = 2,
        left = 3
    }

    public void Awake()
    {
        StartCoroutine(ActivateOnTimer());
    }

    public void Start()
    {
        score = GameObject.Find("ScoreStreak");
        up = gameObject.GetComponent<Transform>().up;
        down = gameObject.GetComponent<Transform>().up * -1;
        left = gameObject.GetComponent<Transform>().right * -1;
        right = gameObject.GetComponent<Transform>().right;
    }

    public void Update()
    {
        Move();
    }

    public void Move()
    {
        if (moveDirection == MoveDirection.up)
        {
            transform.Translate(up * MoveSpeed);
        }
        if (moveDirection == MoveDirection.left)
        {
            transform.Translate(left * MoveSpeed);
        }
        if (moveDirection == MoveDirection.down)
        {
            transform.Translate(down * MoveSpeed);
        }
        if (moveDirection == MoveDirection.right)
        {
            transform.Translate(right * MoveSpeed);
        }
    }

    public void KillTimer()
    {
        KillTime -= 1;
        if(KillTime <= 0)
        {
            Destroy(gameObject);
        }
    }

    IEnumerator ActivateOnTimer()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            //stuff that happens every second happens here:
            KillTimer();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Stick")
        {
            score.GetComponent<ScoreStreak>().score += PointsRewarded;
            Destroy(gameObject);
        }
    }
}
