using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManagerC : MonoBehaviour
{
    public List<WaveProperties> waves;
    private int currentEnemy;
    private float rateEnemy;


    void Start()
    {

    }


    void Update()
    {
        if (currentEnemy < waves[0].Enemies.Count)
        {
            rateEnemy += Time.deltaTime;
            if (rateEnemy > waves[0].Enemies[currentEnemy].spawn)
            {
                GameObject newEnemy = Instantiate(waves[0].Enemies[currentEnemy].enemy, new Vector2(9.5f, Random.Range(-4.5f, 4.5f)), Quaternion.identity);
                waves[0].Enemies[currentEnemy].enemy = newEnemy;
                Destroy(newEnemy, 5);
                rateEnemy = 0;
                currentEnemy++;
            }
        }
    }

}

[System.Serializable]
public class WaveProperties
{
    [System.Serializable]
    public class EnemyProperties
    {
        public float spawn;
        public GameObject enemy;
    }
    public List<EnemyProperties> Enemies;
}
