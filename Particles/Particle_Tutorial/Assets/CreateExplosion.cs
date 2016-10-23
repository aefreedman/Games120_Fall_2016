using UnityEngine;

public class CreateExplosion : MonoBehaviour
{
    public GameObject ExplosionSystemPrefab;

    protected void CreateExplosionAtLocation(Vector3 location)
    {
        var explosion =
            Instantiate(ExplosionSystemPrefab, new Vector3(location.x, location.y), Quaternion.identity) as GameObject;
        var particleSystem = explosion.GetComponent<ParticleSystem>();
        particleSystem.Play();
        Destroy(explosion, particleSystem.duration);
    }
}