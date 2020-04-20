using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float BallSpeed;
    private void Update()
    {
        transform.position += transform.up * Time.deltaTime * BallSpeed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name != "bonus(Clone)")
        {
            float test = 0;
            if (collision.gameObject.tag == "Brick" || collision.gameObject.name == "Border2")
            {
                test = Random.Range(120, 240);
                //transform.rotation = Quaternion.Euler(0, 0, 360);
                //transform.rotation = Quaternion.AngleAxis(test, new Vector3(0, 0, 1));
            }
            if (collision.gameObject.name == "Player")
            {
                test = Random.Range(-15, 15);
            }
            if (collision.gameObject.name == "Border0")
            {
                test = Random.Range(185, 240);
            }
            if (collision.gameObject.name == "Border1")
            {
                test = Random.Range(95, 175);
            }
            transform.rotation = Quaternion.AngleAxis(test, new Vector3(0, 0, 1));

            

        }
        if (collision.gameObject.name == "Border3")
        {
            Destroy(this.gameObject);
        }
    }
}
