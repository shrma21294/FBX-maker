using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fbx : MonoBehaviour
{

	//Variables
	public GameObject cube;
	bool inventoryEnabled;
	
    public GameObject inventory;

	
		void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            if(Input.GetMouseButtonDown(0)){
                print(hit.transform.tag);
                if(hit.transform.tag == "Cube"){
                    Instantiate(cube, new Vector3(0,0,0), Quaternion.identity);
                }
            }
        }
        
         if(Input.GetKeyDown(KeyCode.I)){
            inventoryEnabled =!inventoryEnabled;
         }

         if(inventoryEnabled){
            inventory.SetActive(true);
         }else{
            inventory.SetActive(false);
         }
    }

}


