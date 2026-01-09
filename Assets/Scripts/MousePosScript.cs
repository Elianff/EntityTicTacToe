using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//inspired by https://www.youtube.com/watch?v=IjuG2gZR5xc
public class MousePosScript : MonoBehaviour
{

    public Camera myCamera;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0)){
            Vector3 mousePosition = Input.mousePosition;
            Ray myRay = myCamera.ScreenPointToRay(mousePosition);
            RaycastHit raycastHit;
            

            bool hitSomething = Physics.Raycast(myRay,out raycastHit);

            if (hitSomething && raycastHit.collider.GetComponent<Collider>().tag == "Tile")
            {
                Debug.Log(raycastHit.transform.name);
                //make o visible
            }
            else
            {
                Debug.Log("Hit nothing.");
            }

       
        }
    }
}
