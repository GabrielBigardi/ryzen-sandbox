using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ryzen : PlayableCharacter
{
    // Spawn
    [SerializeField] private float _spawnTime;
    [SerializeField] private Transform _spawnPoint;

    // Logic Stuff
    private bool _spawning = true;

    public bool ready => !this._spawning && !this.isDead;

}
