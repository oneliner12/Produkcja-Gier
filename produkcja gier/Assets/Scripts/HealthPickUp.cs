using UnityEngine;

public class HealthPickUp : MonoBehaviour, IPickup
{
    ParticleSystem particle;
    public void Pickup(Player player)
    {
        player.OnPickupEnter(this);
        
        Destroy(gameObject);
    }
}
