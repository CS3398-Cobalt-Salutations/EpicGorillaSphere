using UnityEngine;
using UnityEngine.Networking;

public class PlayerMove : NetworkBehaviour
{
    public GameObject bulletPrefab;

    public override void OnStartLocalPlayer()
    {
        GetComponent<MeshRenderer>().material.color = Color.red;
    }

    // Update is called once per frame
    void Update ()
    {
        if (!isLocalPlayer) return;

        float x = Input.GetAxis("Horizontal") * 0.1f;
        float z = Input.GetAxis("Vertical") * 0.1f;

        transform.Translate(x, 0.0f, z);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            // The command function is called from the client but invoked by the server
            CmdFire();
        }
    }

    [Command]
    void CmdFire()
    {
        // Create the bullet object from the bullet prefab
        GameObject bullet = (GameObject)Instantiate(bulletPrefab, transform.position - transform.forward, Quaternion.identity);

        // Make the bullet move away in front of the player
        bullet.GetComponent<Rigidbody>().velocity = -transform.forward * 4.0f;

        // Spawn the bullet on the clients
        NetworkServer.Spawn(bullet);

        // Make the bullet disappear after 2 seconds
        Destroy(bullet, 2.0f);
    }
}
