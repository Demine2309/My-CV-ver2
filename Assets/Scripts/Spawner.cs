using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject meteorite;

    [SerializeField] private float minY;
    [SerializeField] private float maxY;

    private float counter;
    [SerializeField] private float spawnerTime = 2f;

    private void Update()
    {
        counter -= Time.deltaTime;
        if (counter < 0)
        {
            counter = spawnerTime;
            Vector2 pos = new Vector2(transform.position.x, Random.RandomRange(minY, maxY));
            Instantiate(meteorite, pos, meteorite.transform.rotation);
        }
    }
}
