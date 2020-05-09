using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class handsani : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    private Transform playerPos;
    private GameObject[] laba;

    void OnMouseDown()
    {
        soundclicked.PlaySound("hand");
        Destroy(gameObject);
        laba = GameObject.FindGameObjectsWithTag ("virus");
        for(int i=0; i<laba.Length;i++)
        {
            soundclicked.PlaySound("virus");
            DestroyObject(laba[i]);
            virus.number ++;
        }
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
