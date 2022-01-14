using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [Header("Needed Objects")]
    [SerializeField] protected Transform _playerSpawnPoint;
    [SerializeField] protected GameObject _player;

    [Header("Config")]
    [SerializeField] [Range(0.2f, 2f)] protected float _spawnDelayTime = 1f;

    protected void Start()
    {
        StartCoroutine(this.SpawnPlayer());
    }

    protected IEnumerator SpawnPlayer()
    {
        yield return new WaitForSeconds(this._spawnDelayTime);
        GameObject player = Instantiate(this._player, this._playerSpawnPoint);
        player.transform.parent = null;
    }
}
