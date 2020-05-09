using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playButton : MonoBehaviour
{
    // Start is called before the first frame update
    public void Muali()
    {
        soundclicked.PlaySound("hand");
        SceneManager.LoadScene("mainplay");
    }
}
