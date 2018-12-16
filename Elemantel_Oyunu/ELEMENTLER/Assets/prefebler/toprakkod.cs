using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class toprakkod : MonoBehaviour {

    public GameObject toprakdusman;
    [HideInInspector] public float speed;
    int ureyen;
    public Vector2 pozisyon;
    Vector2 position;

    void Start ()
    {
        speed = 7f;
    }
	
	void Update ()
    {
        int x = (int)position.x;

        if (transform.position.x > 1 && transform.position.y == 0)
        {
            //sag
            hareket(2);
        }
        else if (transform.position.x < -1 && transform.position.y == 0)
        {
            //sol
            hareket(0);
        }
        else if (transform.position.y > 1 && transform.position.x == 0)
        {
            //ust
            hareket(1);
        }
        else if (transform.position.y < -1 && transform.position.x == 0)
        {
            //alt
            hareket(3);
        } 
    }

    public void hareket(int uremis)
    {
        //sağ
        if (uremis == 0)
        {
            speed = 10f;
            position = transform.position;
            position = new Vector2(position.x + speed * Time.deltaTime, position.y);
            transform.position = position;
        }//aşşağı
        else if (uremis == 1)
        {
            position = transform.position;
            position = new Vector2(position.x, position.y - speed * Time.deltaTime);
            transform.position = position;
        }//sol
        else if (uremis == 2)
        {
            speed = 10f;
            position = transform.position;
            position = new Vector2(position.x - speed * Time.deltaTime, position.y);
            transform.position = position;
        }//yukarı
        else if (uremis == 3)
        {
            position = transform.position;
            position = new Vector2(position.x, position.y + speed * Time.deltaTime);
            transform.position = position;
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "toprak" || col.gameObject.tag == "dusates" || col.gameObject.tag == "dusToprak" || col.gameObject.tag == "dusSu" || col.gameObject.tag == "dusHava")
        {
            Destroy(gameObject);
           
        }

        if (col.gameObject.tag == "hava" || col.gameObject.tag == "ates" || col.gameObject.tag == "su" || col.gameObject.tag == "Player")
        {
            
            sahnedegis();


        }
    }

    public void sahnedegis()
    {

        Application.LoadLevel("MENÜ");
    }
   
}
