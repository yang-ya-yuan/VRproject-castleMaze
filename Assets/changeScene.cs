﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class changeScene : MonoBehaviour
{
    public GameObject endPoint;
    public GameObject player;
    public int nextScene;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider endPoint)
    {
        Destroy(player);
        SceneManager.LoadScene(nextScene);
    }
}
