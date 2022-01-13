using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class changeScene : MonoBehaviour
{
    public GameObject player;
    public int nextScene;
    // public GameObject newPosition;


    // Start is called before the first frame update
    void Start()
    {
        // gameObject.transform.position = newPosition.transform.position;
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider player)
    {
        // Destroy(player);
        SceneManager.LoadScene(nextScene);
    }
}
