using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class retart : MonoBehaviour
{
    public float yFallHeight;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < yFallHeight)
        {
            Debug.Log("me cai");
            SceneManager.LoadScene("Parkour");
        }
    }
}
