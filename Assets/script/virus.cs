using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class virus : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    private Transform playerPos;
    public static int number=0;
    void OnMouseDown()
    {
        soundclicked.PlaySound("virus");
        Destroy(gameObject);
        number++;
    }
    void Start()
    {
        playerPos = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, playerPos.position, speed * Time.deltaTime);
    }
}
