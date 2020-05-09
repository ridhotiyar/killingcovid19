using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class virusCount : MonoBehaviour
{
    // Start is called before the first frame update
    public Text numberVirus;
    void Start()
    {
        numberVirus.text = virus.number.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        numberVirus.text = virus.number.ToString();
    }
}
