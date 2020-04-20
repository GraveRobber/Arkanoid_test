using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public GameObject Player;
    public float PlayerSpeed;

    GameObject[] border = new GameObject[4];

    private void Start()
    {
        //GameObject[] border = new GameObject[4];
        for(int i =0; i < border.Length; i++)
        {
            border[i] = new GameObject();
            border[i].name = "Border" + i;
            border[i].tag = "Reflector";
            border[i].AddComponent<BoxCollider2D>();
        }
       
    }

    private void Update()
    {
        // это рабочее пространство. размер подгоняеться по ширине экрана. в update что мы можно ыло протестировать.
        // так то в start логично было бы запихать..
        float screnwidth = Camera.main.orthographicSize * 2 * Screen.width / Screen.height;
        transform.localScale = new Vector2(screnwidth, Camera.main.orthographicSize * 2);

        // это границы и их позиция тоже в update меняется, что бы они во время игры подстраивались под рамки камеры
        var width = Camera.main.orthographicSize * 2 * Screen.width / Screen.height;
        border[0].transform.position = new Vector3(-width/2 - 0.5f, 0, 1);
        border[1].transform.position = new Vector3(width /2 + 0.5f, 0, 1);
        border[2].transform.position = new Vector3(0, Camera.main.orthographicSize+0.5f, 1);
        border[3].transform.position = new Vector3(0, -Camera.main.orthographicSize-0.5f, 1);

        border[0].transform.localScale = new Vector2(1, Camera.main.orthographicSize * 2);
        border[1].transform.localScale = new Vector2(1, Camera.main.orthographicSize * 2);
        border[2].transform.localScale = new Vector2(width, 1);
        border[3].transform.localScale = new Vector2(width, 1);
    }
    private void OnMouseDrag()
    {
        
        Vector2 MousePose = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 temp = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));

        if (Player != null)
        {
            Player.transform.position = Vector3.MoveTowards(Player.transform.position,
                new Vector3(Mathf.Clamp(MousePose.x, temp.x + 1f, -temp.x - 1f), Player.transform.position.y, 1), Time.deltaTime * PlayerSpeed);
        }
    }
}
