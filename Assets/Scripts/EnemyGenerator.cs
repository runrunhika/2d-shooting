using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject EnemyPrefab;
    public GameObject BossEnemyPrefab;

    private int random;

    // Start is called before the first frame update
    void Start()
    {
        //繰り返し関数を実行する : 2秒後に1秒刻みで実行
        InvokeRepeating("Spawn", 2f, 1f);

        Invoke("BossSpawn", 4f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //敵生成位置をランダムにする
    void Spawn()
    {
        Vector3 spawnPositon = new Vector3(
            Random.Range(-2.9f,2.9f),
            transform.position.y,
            transform.position.z);

        Instantiate(EnemyPrefab, spawnPositon, transform.rotation);
    }

    void BossSpawn()
    {
        Instantiate(BossEnemyPrefab, transform.position, transform.rotation);
        CancelInvoke();
    }

}
