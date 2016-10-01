using UnityEngine;
using UnityEngine.Networking;

public class Combat : NetworkBehaviour
{
    public const int maxHealth = 100;
    public bool destroyOnDeath;

    [SyncVar]
    public int health = 100;

    public void TakeDamage(int amount)
    {
        if (!isServer) return;

        health -= amount;
        if (health <= 0)
        {
            if (destroyOnDeath)
            {
                Destroy(gameObject);
            }
            else
            {
                health = maxHealth;

                // Called on the server, invoked on the clients
                RpcRespawn();
            }
        }
    }

    [ClientRpc]
    void RpcRespawn()
    {
        if (isLocalPlayer)
        {
            // Move back to zero location
            transform.position = Vector3.zero;
        }
    }
}
