using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dusman : MonoBehaviour {

    public Transform[] Dusmanlar;
    public Transform HavaSpawn, SuSpawn, ToprakSpawn, AtesSpawn;
    public int SagRand, SolRand, UstRand, AltRand;
    public float SagSure, SolSure, UstSure, AltSure;
    [HideInInspector] public Vector2 pozisyon;
    [HideInInspector] public float speed = 5f;
        
    void Start ()
    {
		
	}
	
	void Update ()
    {
        SagSure += Time.deltaTime;
        SolSure += Time.deltaTime;
        UstSure += Time.deltaTime;
        AltSure += Time.deltaTime;

        if(SagSure >=10)
        {
            SagRand = Random.Range(0, 4);
            Instantiate(Dusmanlar[SagRand]);
            Vector2 Sag = new Vector2(ToprakSpawn.position.x, ToprakSpawn.position.y);
            Dusmanlar[SagRand].position = Sag;
            SagSure = 0;
        }

        if (SolSure >= 20)
        {
            SolRand = Random.Range(0, 4);
            Instantiate(Dusmanlar[SolRand]);
            Vector2 Sol = new Vector2(HavaSpawn.position.x, HavaSpawn.position.y);
            Dusmanlar[SolRand].position = Sol;
            SolSure = 0;
        }

        if (UstSure >= 30)
        {
            UstRand = Random.Range(0, 4);
            Instantiate(Dusmanlar[UstRand]);//Üretiyor
            Vector2 Ust = new Vector2(SuSpawn.position.x, SuSpawn.position.y);
            Dusmanlar[UstRand].position = Ust;
            UstSure = 0;
        }

        if (AltSure >= 40)
        {
            AltRand = Random.Range(0, 4);
            Instantiate(Dusmanlar[AltRand]);
            Vector2 Alt = new Vector2(AtesSpawn.position.x, AtesSpawn.position.y);
            Dusmanlar[AltRand].position = Alt;
            AltSure = 0;
        }
    }
}