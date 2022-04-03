using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float speed;
    private int damage;

    public void Setup(int damage)
    {
        this.damage = damage;
        GetComponent<Rigidbody>().velocity = transform.forward * speed;
    }
    
    

    private void OnCollisionEnter(Collision other) 
    {
        if(other != null)
        {
            Destroy(gameObject);
        }   
    }

    private void OnTriggerEnter(Collider other) {

        Debug.Log("usli smo u onTriggerEnter!");

        if (other != null) {

            Debug.Log("interaction sa necime, ne znamo cime jos");
            Debug.Log(other.tag);
            Destroy(gameObject);

            if (other.tag == "Enemy") {


                Debug.Log("interaction bullet sa enemyem!");
                other.gameObject.GetComponent<Enemy>().TakeDamage(damage);

            }

            
        }
    }

}
