using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonus : MonoBehaviour
{
    Vector2 border;

    private void Start()
    {
        border = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
    }
    private void Update()
    {
        transform.position += Vector3.down * Time.deltaTime;

        if (this.transform.position.y < border.y)
        {
            Destroy(this.gameObject);
        }
    }

}
