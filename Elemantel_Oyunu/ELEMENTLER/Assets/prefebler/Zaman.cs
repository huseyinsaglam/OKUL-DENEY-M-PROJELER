using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Zaman : MonoBehaviour {

    float aman;
    int zaman, recor;
    public Text Sure;

    void Start ()
    {
        
    }
	
	void Update ()
    {
        aman += Time.deltaTime;
        zaman = (int) aman;
        Sure.text = zaman.ToString();
    }
}
