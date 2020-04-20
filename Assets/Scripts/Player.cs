using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject Ball;
    Ball ballsript;

    private void Start()
    {
        ballsript = Ball.GetComponent<Ball>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Bonus")
        {
            if (Ball != null)
            {
                int i = Random.Range(0, 3);
                switch (i)
                {
                    case 0:
                        ballsript.BallSpeed += 5f;
                        break;

                    case 1:
                        Vector3 test = Ball.transform.rotation.eulerAngles;
                        Instantiate(Ball, Ball.transform.position, Quaternion.AngleAxis(-test.z, new Vector3(0, 0, 1)));
                        break;

                    case 2:
                        this.transform.localScale = this.transform.localScale + new Vector3(0.25f, 0, 0);
                        break;
                }
                Destroy(collision.gameObject);
            }
        }
    }
}
