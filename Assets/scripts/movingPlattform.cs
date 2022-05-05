using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingPlattform : MonoBehaviour
{

    public GameObject pos1;
    public GameObject pos2; 

    private Vector2 p1;
    private Vector2 p2;
    private Vector2 currentPos;

    public float currentZ;

    public float speed = 1;
    private Vector2 nextPos;

    private Vector2 v3ToV2(Vector3 input)
    {
        Vector2 output;
        output.x = input.x;
        output.y = input.y;

        return output;
    }

    private void Start()
    {
        nextPos = pos2.transform.position;
        currentZ = transform.position.z;

        Vector3 pos1Transform = pos1.GetComponent<Transform>().position;

        p1 = v3ToV2(pos1Transform);


        Vector3 pos2Transform = pos2.GetComponent<Transform>().position;

        p2 = v3ToV2(pos2Transform);

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        currentPos = v3ToV2(transform.position);



        if(p1 == currentPos)
        {
            nextPos = p2;
        }
        else if(currentPos == p2)
        {
            nextPos = p1;
        }


        Vector3 newPosition = new Vector3(transform.position.x, transform.position.y, 0);
        transform.position = Vector3.MoveTowards(newPosition, nextPos, speed * Time.deltaTime);

        
    }

}
