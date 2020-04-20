using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public GameObject Brick;
    public int lvl = 0;

    private void Update()
    {
        if(Brick.transform.childCount == 0)
        {
            if (lvl == 1)
            {
                SceneManager.LoadScene(1);

            }
            if (lvl == 2)
            {
                SceneManager.LoadScene(2);
            }
        }
        
    }

}
