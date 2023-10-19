using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{

    public int inventory;
   
    public float speed = 1f;
    [SerializeField] Text score;
    bool Gameover;


    // Start is called before the first frame update
    void Start()
    {


      


    }

    // Update is called once per frame
    void Update()
    {



        GameOver();


        //Move Script

        if (Input.GetKeyDown(KeyCode.A))
        {
           transform.position += Vector3.left;

        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position += Vector3.right;
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.position += Vector3.up;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position += Vector3.down;
        }




        
    }


    private void GameOver()
    {

        //Game Restart

        GameObject.FindGameObjectsWithTag("Candy");
        
            if (GameObject.FindGameObjectsWithTag("Candy") == null)
            {
                Gameover = true;
            Debug.Log("bruh");
            
            SceneManager.LoadScene("SampleScene");
            }

            if (GameObject.FindGameObjectsWithTag("Candy") != null)
            {
                Gameover = false;
            Debug.Log("bhelp");
        }

        


      //  if (Gameover == true )
       // {
       //     SceneManager.LoadScene("SampleScene");
      //  }
    }

    //The Money Collections
    public void OnTriggerEnter(Collider other)
    {

        if (other.transform.tag == "Candy")
        {
            inventory = inventory + 1;

            Debug.Log(inventory);
        }

        //Game Restart




    }


}
