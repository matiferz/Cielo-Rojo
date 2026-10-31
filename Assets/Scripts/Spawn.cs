using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spawn : MonoBehaviour
{
    [SerializeField] private GameObject[] _toSpawn;
    [SerializeField] private float secondSpawn = 0.3f;
    [SerializeField] private float minTras;
    [SerializeField] private float maxTras;

    void Start()
    {
        StartCoroutine(ObjectSpawn());
    }

    void Update()
    {

        secondSpawn = 1f;
    }

    IEnumerator ObjectSpawn()
    {
        while (true)
        {
            var wanted = Random.Range(minTras, maxTras);
            var position = new Vector2(wanted, wanted);
            GameObject objectSpawning = Instantiate(_toSpawn[Random.Range(0, _toSpawn.Length)], position, Quaternion.identity);
            yield return new WaitForSeconds(secondSpawn);
        }
    }
}