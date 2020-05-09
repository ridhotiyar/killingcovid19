using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playGo : MonoBehaviour
{
    // Start is called before the first frame update
    void OnMouseDown()
    {
        soundclicked.PlaySound("hand");
        Destroy(gameObject);
    }
}
