using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private GameObject _enemy;
    [SerializeField] private int _numbersEnemy;
    [SerializeField] private int _spawnDelay;
    [SerializeField] private int _heightAdjustment;
    

    private void Start()
    {
        var _coroutineSpawnInWork = StartCoroutine(Spawn());
    }

    private IEnumerator Spawn()
    {
        for (int i = 0; i < _numbersEnemy; i++)
        {
            GameObject newEnemy = Instantiate(_enemy, _spawnPoints[Random.Range(0, _spawnPoints.Length)].position, Quaternion.identity);
            Transform newEnemyTranform = newEnemy.GetComponent<Transform>();
            newEnemyTranform.Translate(Vector2.up * _heightAdjustment);
            yield return new WaitForSecondsRealtime(_spawnDelay); 
        }  
    }
}
