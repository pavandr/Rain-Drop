using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeLoss : MonoBehaviour
{
    private void OnParticleCollision(GameObject other)
    {
        Debug.Log("Game over" + other);
    }
   
}
