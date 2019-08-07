using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fbx : MonoBehaviour
{

	//Variables
	public GameObject cube;
	bool inventoryEnabled;
	
    public GameObject inventory;
    public GameObject itemManager;

	
		void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            if(Input.GetMouseButtonDown(0)){
                AddItem(hit.transform.tag);
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

    void AddItem(string tag){
        if(tag == "Cube"){
            GameObject cube1= Instantiate(cube, new Vector3(0,0,0), Quaternion.identity);
            cube1.transform.parent = itemManager.transform;
            cube1.transform.position = itemManager.transform.position;
        }
    }

}


