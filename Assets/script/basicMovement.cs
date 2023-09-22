using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basicMovement : MonoBehaviour
{
    public GameObject hazard;
    public GameObject[] hazards;
   // public GameObject[] coins;
    Vector3 startPos;
    public AudioClip deathlul;
    AudioSource player;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        player = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W)){
            transform.position += Vector3.forward;
        }
        if(Input.GetKeyDown(KeyCode.S)){
            transform.position += Vector3.back;
        }
        if(Input.GetKeyDown(KeyCode.D)){
            transform.position += Vector3.right;
        }
        if(Input.GetKeyDown(KeyCode.A)){
            transform.position += Vector3.left;   
        }/*
        if(Input.GetKeyDown(KeyCode.Q)){
            transform.position += Vector3.down;   
        }
        if(Input.GetKeyDown(KeyCode.E)){
            transform.position += Vector3.up;   
        }*/
/*
        if(transform.position == hazard.transform.position){
            Debug.Log("you are hazards :<");
            Destroy(gameObject);
        }
*/
        for(int i=0; 1 < hazards.Length; i++){
            if(transform.position == hazards[i].transform.position){
            Debug.Log("you are hazards :<");
            //Destroy(gameObject);
            transform.position = startPos;
            player.PlayOneShot(deathlul, 0.75f);
        }
/*
        }
        for(int i=0; 1 < coins.Length; i++){
            if(transform.position == coins[i].transform.position){
            Destroy(coins);
            }*/

        }
    }
}
