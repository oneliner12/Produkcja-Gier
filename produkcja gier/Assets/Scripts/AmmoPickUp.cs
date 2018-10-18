using UnityEngine;

public class AmmoPickUp : MonoBehaviour, IPickup
{
    public void Pickup(Player player)
    {
        player.OnPickupEnter(this);
        Destroy(gameObject);
    }
}
