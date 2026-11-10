using System.Collections;
using UnityEngine;

public class Respawner : MonoBehaviour
{
    [SerializeField] Gem gemPrefab;
    [SerializeField] Transform spawnPoint;
    [SerializeField] float respawnDelay;

    void OnEnable()
    {
        Gem.Damage += RespawnGem;
    }

    void OnDisable()
    {
        Gem.Damage -= RespawnGem;
    }

    void RespawnGem()
    {
        StartCoroutine(RespawnGemCoroutine());
    }

    IEnumerator RespawnGemCoroutine()
    {
        yield return new WaitForSeconds(respawnDelay);
        SpawnGem();
    }

    void SpawnGem()
    {
        Instantiate(gemPrefab, spawnPoint.position, Quaternion.identity);
    }
}

