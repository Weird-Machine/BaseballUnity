using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System;
using UnityEngine;

public class onTouch : MonoBehaviour
{
    public GameObject oggettoPresoInPrestito;
    public GameObject oggettoPresoInPrestitoCandeliere;
    public GameObject oggettoPresoInPrestitoDogCadente;
    private Animator anim;
    float tempoCorrente;
    float minHoldTime = .2f;
    float holdTime = 0f;


    private IEnumerator candeliereFalling()
    {
        for (;;)
        {
            GameObject candeliere = GameObject.Instantiate(oggettoPresoInPrestitoCandeliere, new Vector3(0.19f, 4.25f, -1.724285f), Quaternion.identity);
            yield return new WaitForSeconds(UnityEngine.Random.Range(0.2f , 1f));
            GameObject dogCadente = GameObject.Instantiate(oggettoPresoInPrestitoDogCadente, new Vector3(0.19f, 4.25f, -1.724285f), Quaternion.identity);//fare in modo che cada giù
            yield return new WaitForSeconds(UnityEngine.Random.Range(0.2f, 1f));
            // lavorare con le collisioni im modo tale da fare collidere i lampadari con il cane seduto ed ucciderlo, invece quando collide con i cani non succederà niente 
        }
            
    }

    void Start()
    {
        oggettoPresoInPrestito = GameObject.FindGameObjectWithTag("Player"); 
        oggettoPresoInPrestitoCandeliere = GameObject.Find("candeliere");
        oggettoPresoInPrestitoDogCadente = GameObject.Find("dogCadente");//fare in modo da instanziare il prefab e non l'oggetto.
        anim = oggettoPresoInPrestito.GetComponent<Animator>();
        StartCoroutine(candeliereFalling());
    }
    
 
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Debug.Log("Mouse");
            
            holdTime += Time.deltaTime;
            if (holdTime >= minHoldTime)
            {
                anim.SetBool("isAttack", false);
                holdTime = 0;
            }
            else
            {
                anim.SetBool("isAttack", true);
                
            }
            
        }

        if (Input.GetMouseButtonUp(0))
        {            
            anim.SetBool("isAttack", false);
        }
    }
}
