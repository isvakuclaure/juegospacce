using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float ShootRateTime;
    public GameObject bullet, soundManager;
     CharacterController playercontroller;
     Vector3 movement = Vector3.zero;
    bool disparo=true;
    // Start is called before the first frame update
    void Start()
    {
        playercontroller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        movement = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        movement = transform.TransformDirection(movement);
        playercontroller.Move(movement * Time.deltaTime * 50);

        if (disparo && Input.GetKeyDown("space"))
        {
        
                

                    soundManager.SendMessage("playBulletSound");
                    GameObject newBullet = Instantiate(bullet, transform.position, Quaternion.identity);
                    newBullet.GetComponent<Rigidbody>().AddForce(Vector3.up * 2000);
                    Destroy(newBullet, 3);


                disparo = false;
                Invoke("espera",ShootRateTime);
                

            
        }
    }
    void espera()
    {
       
                disparo = true;
          
        
    }
     
}
