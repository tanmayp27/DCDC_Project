using Fusion;
using UnityEngine;

public class PlayerSpawner : SimulationBehaviour, IPlayerJoined
{
    public GameObject PlayerPrefab;
    public Transform SpawnPoints;

    public void PlayerJoined(PlayerRef player)
    {
        
        if (player == Runner.LocalPlayer)
        {
            Runner.Spawn(PlayerPrefab, SpawnPoints.position, Quaternion.identity, player);
        }
    }
}