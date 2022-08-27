using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private GameObject _enemy;
    [SerializeField] private int _numbersEnemyForSpawn;
    [SerializeField] private int _spawnDelay;

    private WaitForSecondsRealtime _waitForSecondsRealtime;

    private void Start()
    {
        _waitForSecondsRealtime = new WaitForSecondsRealtime(_spawnDelay);
        StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        for (int i = 0; i < _numbersEnemyForSpawn; i++)
        {
            Instantiate(_enemy, _spawnPoints[Random.Range(0, _spawnPoints.Length)].position, Quaternion.identity);
            yield return _waitForSecondsRealtime;
        }
    }
}
