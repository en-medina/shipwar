using UnityEngine;
using System.Collections;

public class AmmoCollider : MonoBehaviour 
{
    void OnTriggerExit2D(Collider2D Collide)
    {


        Destroy(Collide.gameObject);
    }

}
