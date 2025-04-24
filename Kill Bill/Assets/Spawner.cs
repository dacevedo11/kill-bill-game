using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] 
    private GameObject _prefab;

    [SerializeField]
    private float _minimumSpawnTime;

    [SerializeField]
    private float _maximumSpawnTime;

    private float _timeUntilNextSpawn;


    void Awake()
    {
        SetTimeUntilSpawn();
    }

    void Update()
    {
        _timeUntilNextSpawn -= Time.deltaTime;

        if (_timeUntilNextSpawn <= 0)
        {
            Instantiate(_prefab, transform.position, Quaternion.identity);
            SetTimeUntilSpawn();
        }
    }


    private void SetTimeUntilSpawn()
    {
        _timeUntilNextSpawn = Random.Range(_minimumSpawnTime, _maximumSpawnTime);
    }
}
