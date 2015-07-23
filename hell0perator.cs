using UnityEditor;
 using UnityEngine;
 
 [InitializeOnLoad]
 class MyClass
 {
     static MyClass ()
     {
         EditorApplication.update += Update;
     }
 
     static void Update ()
     {
         Debug.Log("Updating");
     }
 }

 // get a callback called every frame auto