using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionElt : MonoBehaviour
{
   

    public void OnTriggerEnter2D(Collider2D collision){
        if(collision.name == "SablierFin"){
            Destroy(GameObject.Find("SablierFin"),0.5f);
            gameObject.GetComponent<PlayerMovement>().enabled = false;
        }

        else if(collision.name == "Vent"){
           Destroy(GameObject.Find("Vent"),0.5f);
        }

        else if(collision.name == "Foudre"){
           Destroy(GameObject.Find("Foudre"),0.5f);
        }
        
        else if(collision.name == "Pluie"){
           Destroy(GameObject.Find("Pluie"),0.5f);
        }
    }
}
