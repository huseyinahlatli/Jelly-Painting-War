using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planeIsTrigger : MonoBehaviour
{
    public Material[] changedMaterial;
    Renderer nRend;
    private bool collisionState;

    void Start()
    {
        nRend = GetComponent<Renderer>();
        nRend.enabled = true;
        nRend.sharedMaterial = changedMaterial[0];
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.C) && collisionState){
            StartCoroutine(WaitPainting());
        }
    }

    IEnumerator WaitPainting()
    {        
        if(Input.GetKeyDown(KeyCode.C) && collisionState)
        {
            yield return new WaitForSeconds(0);
            nRend.sharedMaterial = changedMaterial[1];
        }
    }

    void OnCollisionStay(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            collisionState = true;
        }

        else
        {
            collisionState = false;
        }
    }

    void OnCollisionExit(Collision other)
    {
        collisionState = false;    
    }
}
