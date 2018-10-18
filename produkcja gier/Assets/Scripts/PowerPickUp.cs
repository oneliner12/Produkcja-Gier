using UnityEngine;

public class PowerPickUp : MonoBehaviour, IPickup
{
    ParticleSystem particle;
    public void Pickup(Player player)
    {
        player.OnPickupEnter(this);
        Destroy(gameObject);
    }
}