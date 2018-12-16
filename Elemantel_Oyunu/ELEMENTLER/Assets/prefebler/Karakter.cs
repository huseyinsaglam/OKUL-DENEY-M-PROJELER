using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Karakter : MonoBehaviour {

    public GameObject [] mermi;
    public GameObject [] mermipoz;
    int yon;

    void Start ()
    {
		
	}
	
	void Update ()
    {
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            yon = 1;
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            yon = 0;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            yon = 2;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            yon = 3;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            GameObject mermiii = (GameObject)Instantiate(mermi[0]);
            mermiii.transform.position = mermipoz[yon].transform.position;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            GameObject mermiii = (GameObject)Instantiate(mermi[1]);
            mermiii.transform.position = mermipoz[yon].transform.position;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            GameObject mermiii = (GameObject)Instantiate(mermi[2]);
            mermiii.transform.position = mermipoz[yon].transform.position;
        }
        else if (Input.GetKeyDown(KeyCode.F))
        {
            GameObject mermiii = (GameObject)Instantiate(mermi[3]);
            mermiii.transform.position = mermipoz[yon].transform.position;
        }
    }
}

