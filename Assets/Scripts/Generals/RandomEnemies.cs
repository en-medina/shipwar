using UnityEngine;
using System.Collections;

public class RandomEnemies : MonoBehaviour 
{
    
    public float TimePerEnemies = 5f;
    public int MaximiumEnemies = 1;
    public GameObject[] EnemiesObject;


    private const int ShipsAmount = 4;
    private float Timer = 0f;
    private GameObject AccObject;
    private Vector3 LaunchEnemies = new Vector3(16f, 0f, 0f);
    private float[] YPositions = { 2.5f, 0.5f, -1.5f, -3.5f };
    
    void Awake()
    {
    
    }

    void Start()
    {
        Timer = TimePerEnemies;
    }

    void Update()
    {
        if(Timer<0)
        {
            Timer = TimePerEnemies;
            TimeToAttack();
        }
        Timer -= Time.deltaTime;
    }

    void TimeToAttack()
    {
        int Search = RandomGenerator(MaximiumEnemies);
        AccObject = (GameObject)Instantiate(EnemiesObject[Search], transform.position, transform.rotation);
        AccObject.transform.parent = transform.parent;
        LaunchEnemies.y = YPositions[RandomGenerator(ShipsAmount)];
        AccObject.transform.position = transform.position + LaunchEnemies;
    }

    int RandomGenerator(int MaxValue)
    {
        return Random.Range(0, MaxValue);
    }

}
