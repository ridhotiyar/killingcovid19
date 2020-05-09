using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class finalTime : MonoBehaviour
{
    // Start is called before the first frame update
    public Text hasilAkhir;
    void Start()
    {
        hasilAkhir.text = timecount.finalTime;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
