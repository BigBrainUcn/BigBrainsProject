using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerFlies : MonoBehaviour
{
    public GameObject Flies;
    private float timeBtwSpawn;
    public float startTimeBtwSpawn;
    public float decreaseTime;
    public float minTime = 0.65f;

    private void Update(){
        if(timeBtwSpawn <= 0){
            Instantiate(Flies, transform.position, Quaternion.identity);
            timeBtwSpawn = startTimeBtwSpawn;
        }
        else{
            timeBtwSpawn -= Time.deltaTime;
        }
    }
    
}