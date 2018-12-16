using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mermi : MonoBehaviour
{
    [HideInInspector] public float speed;
    float zaman;

    void Start()
    {
        speed = 30f;
    }
    
    void Update()
    {
        if (transform.position.x > 0 && transform.position.y == 0)
        {
            //sag
            Vector2 SagPozisyon = transform.position;
            SagPozisyon = new Vector2(SagPozisyon.x + speed * Time.deltaTime, SagPozisyon.y);
            transform.position = SagPozisyon;
            Vector2 Sagmax = Camera.main.ViewportToWorldPoint(new Vector2(1, 0));
            if (transform.position.x > Sagmax.x)
            {
                Destroy(gameObject);
            }
        }
        if (transform.position.x < 0 && transform.position.y == 0)
        {
            //sol
            Vector2 Solposition = transform.position;
            Solposition = new Vector2(Solposition.x - speed * Time.deltaTime, Solposition.y);
            transform.position = Solposition;
            Vector2 Solmax = Camera.main.ViewportToWorldPoint(new Vector2(1, 0));
            if (-transform.position.x > Solmax.x)
            {
                Destroy(gameObject);
            }
        }
        if (transform.position.y > 0 && transform.position.x == 0)
        {
            //ust
            Vector2 Ustposition = transform.position;
            Ustposition = new Vector2(Ustposition.x, Ustposition.y + speed * Time.deltaTime);
            transform.position = Ustposition;
            Vector2 Ustmax = Camera.main.ViewportToWorldPoint(new Vector2(0, 1));
            if (transform.position.y > Ustmax.y)
            {
                Destroy(gameObject);
            }
        }
        if (transform.position.y < 0 && transform.position.x == 0)
        {
            //alt
            Vector2 Altposition = transform.position;
            Altposition = new Vector2(Altposition.x, Altposition.y - speed * Time.deltaTime);
            transform.position = Altposition;
            Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(0, 1));
            if (-transform.position.y > max.y)
            {
                Destroy(gameObject);
            }
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        
        if (col.gameObject.tag == "dusates" || col.gameObject.tag == "dusToprak" || col.gameObject.tag == "dusSu" || col.gameObject.tag == "dusHava" ||
            col.gameObject.tag == "ates" || col.gameObject.tag == "su" || col.gameObject.tag == "hava" || col.gameObject.tag == "toprak")
        {
            Destroy(gameObject);
            
            
        }

    }
}