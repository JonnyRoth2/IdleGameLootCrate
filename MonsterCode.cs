using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterManager : MonoBehaviour
{
    public GameObject[] MonsterPrefabs;

    public Monster curMonster;

    public Transform canvas;

    public static MonsterManager instance;
    
    void Awake()
    {
        instance=this;
    }
//Spawns in a New monster to fight
    public void SpawnMonster()
    {
        GameObject monsterToSpawn=MonsterPrefabs[Random.Range(0, MonsterPrefabs.Length)];
        GameObject obj=Instantiate(monsterToSpawn, canvas);
        curMonster = obj.GetComponent<Monster>();

    }
//Replaces the Monster with a new Monster 
    public void ReplaceMonster(GameObject Monster)
    {
        Destroy(Monster);
        SpawnMonster();
    }

}
