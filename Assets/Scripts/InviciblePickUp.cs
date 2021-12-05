using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InviciblePickUp : MonoBehaviour
{
    public AudioClip InvincPickUp;

    void OnTriggerEnter2D(Collider2D other)
    {
        RubyController controller = other.GetComponent<RubyController>();

        if (controller != null)
        {
            controller.Invincible(true);
            Destroy(gameObject);

            controller.PlaySound(InvincPickUp);
        }
    }
}
