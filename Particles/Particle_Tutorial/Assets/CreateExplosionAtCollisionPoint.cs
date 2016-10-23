using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class CreateExplosionAtCollisionPoint : CreateExplosion
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        var p = collision.contacts[0].point;
        Debug.LogFormat("Contact at {0}", p);
        CreateExplosionAtLocation(collision.contacts[0].point);
    }
}