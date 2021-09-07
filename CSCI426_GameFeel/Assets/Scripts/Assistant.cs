 using UnityEngine;
 using System.Collections;
 
 public class Assistant : MonoBehaviour {
     public Vector3 UltimatePosition = new Vector3(0,0,0);
     float X, Y;
 
     // Use this for initialization
     void Start () {
 
     
     }
     
     // Update is called once per frame
     void Update () {
 
         X = Input.mousePosition.x;
         Y = Input.mousePosition.y;
         Vector3 mouselocation = Camera.main.camera.ScreenToWorldPoint(Input.mousePosition);
         transform.position = mouselocation;
         //print("MouseX: " + X + " MouseY: " + Y);
 
         //print(transform.position.x + "," + transform.position.y + "," + transform.position.z);
         if (Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1)  == true) {
             print("click");
                 }
 
     }
 }