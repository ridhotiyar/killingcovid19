using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class finalScores : MonoBehaviour
{
    // Start is called before the first frame update
    public Text skorAkhir;
    void Start()
    {
        skorAkhir.text = virus.number.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
