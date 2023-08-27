using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile: MonoBehaviour
{
    public float speed;
    [SerializeField] private List<Transform> _points = new List<Transform>();
    [SerializeField] private GameObject _coin;
    [SerializeField] private GameObject _barrier;
    private int _del;

    void Start()
    {
        Spawn();
    }

    
    void FixedUpdate()
    {
        if (!FindObjectOfType<Barrier>()._isDead)
        {
            transform.Translate(Vector3.back * speed * Time.fixedDeltaTime);
        }
        
    }
    
    private void Spawn()
    {
        int randCountCoins = Random.Range(0, 101);
        switch (randCountCoins)
        {
            case (< 50):
                _points.RemoveAt(SpawnedCoin());

                _points.RemoveAt(SpawnedBarrier());

                break;

            case (< 90):
                
                _points.RemoveAt(SpawnedCoin());

                _points.RemoveAt(SpawnedCoin());

                _points.RemoveAt(SpawnedBarrier());
                break;
            case (< 100):
                _points.RemoveAt(SpawnedCoin());

                _points.RemoveAt(SpawnedCoin());

                _points.RemoveAt(SpawnedCoin());
                break;
        }
    }

    private int SpawnedCoin()
    {
        int randPointIndex = Random.Range(0, _points.Count);
        GameObject newCoin = Instantiate(_coin, _points[randPointIndex].position, Quaternion.identity);
        
        newCoin.transform.SetParent(transform);
        
        return randPointIndex;
    }
    private int SpawnedBarrier()
    {
        int randPointIndex = Random.Range(0, _points.Count);
        GameObject newBarrier = Instantiate(_barrier, _points[randPointIndex].position, Quaternion.identity);

        newBarrier.transform.SetParent(transform);

        return randPointIndex;
    }
}
