 using UnityEngine;
 using UnityEditor;
 
 [InitializeOnLoad] // This is the special sauce yUm
 public class Autorun
 {
     static Autorun()
     {
         Debug.Log("Autorun!");
     }
 }

 // Autorun script when project finishes loading
 // Save in Editor folder