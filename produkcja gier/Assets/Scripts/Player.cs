using UnityEngine;
using System;

public class Player : MonoBehaviour
{
   [SerializeField] float ammo, health;
   public bool invincible = false;

    public void OnPickupEnter(HealthPickUp Pickup)
    {
        health += 20;
    }
    public void OnPickupEnter(AmmoPickUp Pickup)
    {
        ammo += 10;      
    }
    public void OnPickupEnter(PowerPickUp Pickup)
    {
        invincible = true;
        Scheduler._Instance.Scheduleparameter(10, () =>
        {
            invincible = false;

        });
    }

    private void OnTriggerEnter(Collider collider)
    {
        IPickup pickup = collider.GetComponent<IPickup>();
        if (pickup != null)
        {
            pickup.Pickup(this);
        }

    }

}