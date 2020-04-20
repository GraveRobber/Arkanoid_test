using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    public int life;
    public bool Bonus;
    public GameObject BonusPref;
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        life--;
        int i = Random.Range(0, 10);
        if(life == 0)
        {
            if (Bonus && i > 5)
            {
                Instantiate(BonusPref, this.gameObject.transform.position, Quaternion.identity);
            }
            Destroy(this.gameObject);
        }
    }
   

}
