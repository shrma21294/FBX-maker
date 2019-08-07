using UnityEditor;
using UnityEditor.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePrefab: MonoBehaviour
{
    
   public void CreatePre()
    {
        // Keep track of the currently selected GameObject(s)
       // GameObject[] objectArray = Selection.gameObjects;

        // Loop through every GameObject in the array above
       // foreach (GameObject gameObject in objectArray)
      //  {
            // Set the path as within the Assets folder,
            // and name it as the GameObject's name with the .Prefab format
            string localPath = "Assets/GeratedPrefabs" + this.gameObject.name + ".prefab";

            // Make sure the file name is unique, in case an existing Prefab has the same name.
            localPath = AssetDatabase.GenerateUniqueAssetPath(localPath);

            // Create the new Prefab.
            PrefabUtility.SaveAsPrefabAssetAndConnect(this.gameObject, localPath, InteractionMode.UserAction);
       // }
    }

}
