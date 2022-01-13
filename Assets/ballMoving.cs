using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballMoving : MonoBehaviour
{
    public float movingSpeed = 7f;
    float timecount;
    // Start is called before the first frame update
    void Start()
    {
        timecount = 0;
    }

    // Update is called once per frame
    void Update()
    {

        if(timecount < 12)
        {
            gameObject.transform.position += gameObject.transform.forward* movingSpeed* Time.deltaTime;
        }
        else
        {
            movingSpeed *= -1;
            timecount = 0;
        }
        timecount += Time.deltaTime;
        
    }
}
