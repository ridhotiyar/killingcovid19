using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other)
    {
        // if (collisionInfo.collider.tag == "Player")
        // {
        //     //movement.enable = false;
        //     //FindObejectOfType<GameManager>().EndGame;
        //     Debug.Log("GAME OVER");
        // }
        if(other.gameObject.tag == "virus")
        {
            SceneManager.LoadScene("GameOver");
            GameObject.Find("Textwaktu").SendMessage("Finnish");
        }
    }
}
