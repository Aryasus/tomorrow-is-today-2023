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
            GameObject.Find("Vent").SetActive(false);
           //Destroy(GameObject.Find("Vent"),0.5f);
        }

        else if(collision.name == "Orage"){
           Destroy(GameObject.Find("Orage"),0.5f);
        }
        
        else if(collision.name == "Pluie"){
           Destroy(GameObject.Find("Pluie"),0.5f);
        }
    }
}
