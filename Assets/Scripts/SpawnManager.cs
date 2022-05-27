using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] float spawnDelayMax;
    [SerializeField] float spawnDelayMin;
    [SerializeField] List<GameObject> fruitList;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnFruit());
    }

    IEnumerator spawnFruit(){
        //Spawn random fruit on a semi-random delay within the play area.
        float spawnArea =  GameManager.Instance.getPlayArea()/2;
        do{
            float spawnDelay = Random.Range(spawnDelayMin,spawnDelayMax);
            yield return new WaitForSeconds(spawnDelay);
            GameObject fruitToSpawn = fruitList[Random.Range(0,fruitList.Count)];
            float spawnPos = Random.Range(-spawnArea,spawnArea);
            Instantiate(fruitToSpawn, new Vector3(spawnPos,25,0), fruitToSpawn.transform.rotation);
        }while(GameManager.Instance.gameRunning);
        Debug.Log("Spawn Stop");
    }
}
