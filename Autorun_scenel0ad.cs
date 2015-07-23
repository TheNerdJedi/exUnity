using UnityEngine;
using UnityEditor;
 
 [InitializeOnLoad]
 public class Autorun
 {
     static Autorun()
     {
         EditorApplication.update += RunOnce;
     }
 
     static void RunOnce()
     {
         Debug.Log("RunOnce!");
         EditorApplication.update -= RunOnce;
     }
 }

// Scene to be fully loaded before startup op
// so you can use Object.FindObjectsOfType
 
// defer objects until first editor update