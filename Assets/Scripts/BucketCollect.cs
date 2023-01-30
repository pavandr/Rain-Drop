using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BucketCollect : MonoBehaviour
{
    public Button left;
    public Button right;
    public GameObject bucket;
    public float moveSpeed;
    private bool boundary;

    public void Update()
    {
        bucketMove();
    }

    private void OnParticleCollision(GameObject other)
    {
        Debug.Log("Collider" + other);
    }
    public void bucketMove()
    {
        if(Input.GetMouseButton(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if(mousePos.x>1)
            {
                //Move Right
                transform.Translate(moveSpeed * Time.deltaTime, 0, 0);
            }
            else if(mousePos.x<-1)
            {
                //Move Left
                transform.Translate(-moveSpeed*Time.deltaTime, 0, 0);
            }
        }

    }
    public void moveleft()
    {
        Debug.Log("moving left");
    }
    public void moveright()
    {
        Debug.Log("moving right");
    }
}
