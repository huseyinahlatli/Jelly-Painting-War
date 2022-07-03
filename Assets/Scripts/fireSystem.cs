using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireSystem : MonoBehaviour
{
    Camera cam;
    public bool insert;
    Material changeMaterial;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    IEnumerator Delay() 
    {
        yield return new WaitForSeconds(3);
    }

    private void OnTriggerEnter(Collider other)
    {
        changeMaterial = GetComponent<Renderer>().material;
        if(GameObject.FindWithTag("tagFloor"))
        {
            if(Input.GetKeyDown(KeyCode.C))
            {
                Debug.Log("worked");
                this.gameObject.GetComponent<Renderer>().material.color = Color.cyan;
                changeMaterial.color = Color.red;
            }
        }
    }


    void Shooting()
    {
        Ray ray = cam.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0)); // Ekranin Merkez Noktasi
    }
}
