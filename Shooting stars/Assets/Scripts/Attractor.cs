using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attractor : MonoBehaviour
{
    const float G = 667.4f;
    public Rigidbody2D rb;
    void FixedUpdate()
    {
        Attractor[] attractors= FindObjectsOfType<Attractor>();
        foreach (Attractor attractor in attractors)
        {
            if (attractor != this)
            { Attract(attractor); }
        }
    }
    void Attract(Attractor objToAttract)
    {
        Rigidbody2D rbToAttract = objToAttract.rb;

        Vector2 direction = rb.position - rbToAttract.position;
        float distance = direction.magnitude;
        float forceMagnitude = G*(rb.mass * rbToAttract.mass) / Mathf.Pow(distance, 3);
        Vector2 force = direction.normalized * forceMagnitude;
        rbToAttract.AddForce(force);

    }

}
