using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemy;
    public float spawnRate = 2; //how many seconds between spawns
    private float timer = 0; //a number that counts up
    public float widthOffset = 10;
    void Start()
    {
        
    }

    void Update()
    {
        float maxLeftPoint = transform.position.x - widthOffset;
        float maxRightPoint = transform.position.x + widthOffset;

        if (timer < spawnRate)
        {
            timer += Time.deltaTime; //creates a number that counts up every frame
        }
        else
        {
            Instantiate(enemy, new Vector3(transform.position.y, Random.Range(maxLeftPoint, maxRightPoint), 0), transform.rotation); //spawn
            timer = 0; //reset
        }
    }
}
