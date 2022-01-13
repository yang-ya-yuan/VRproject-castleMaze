using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chestMoving : MonoBehaviour
{
    public float movingSpeed = -50f; 
    //  public Vector3 xCoordinate; //current angle
    public float maxtime = 3;
    private float timecount=0;

    // Start is called before the first frame update
    void Start()
    {
        // xCoordinate = gameObject.transform.eulerAngles;
        timecount=0;
    }

    // Update is called once per frame
    void Update()
    {
        // transform.eulerAngles = Vector3(transform.eulerAngles.y, )
        transform.Rotate(new Vector3(-movingSpeed,0f,0f)*Time.deltaTime);
        if(timecount>=maxtime){
            movingSpeed*=-1;
            timecount=0;
        }
        timecount+= Time.deltaTime;
    }

}
