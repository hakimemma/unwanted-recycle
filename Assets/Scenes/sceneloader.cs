using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneloader : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player")
        {
             if(Input.GetKey(KeyCode.E))
             {
                SceneManager.LoadScene(1);
             }
        }
            



    }
       
}
