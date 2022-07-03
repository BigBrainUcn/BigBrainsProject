using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerPaper : MonoBehaviour
{
    public GameObject Paper;
    private float timeBtwSpawn;
    public float startTimeBtwSpawn;
    public float decreaseTime;
    public float minTime = 0.65f;

    private void Update(){
        if(timeBtwSpawn <= 0){
            Instantiate(Paper, transform.position, Quaternion.identity);
            timeBtwSpawn = startTimeBtwSpawn;
            if(startTimeBtwSpawn > minTime){
                startTimeBtwSpawn -= decreaseTime;
            }
            
        }
        else{
            timeBtwSpawn -= Time.deltaTime;
        }
    }
    
}
