using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
   void OnTriggerEnter(Collider other) {
       if(other.name == "Player")
       {
           Debug.Log("Player detected-- attack!");
       }
   }

   private void OnTriggerExit(Collider other) {
       if(other.name == "Player")
       {
           Debug.Log("Player out of range! Resume patrol.");
       }
   }
}
