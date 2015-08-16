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
    private Vector3 LaunchEnemies = new Vector3(31f, 0f, 0f);
    private float[] YPositions = { 10.6f, 4.6f, -1.4f, -7.4f };
    private float DificultCounter =0f;
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
            if (TimePerEnemies - DificultCounter > 0.7f)
                Timer = TimePerEnemies - DificultCounter;
            else
                Timer = 0.7f;
            TimeToAttack();
            DificultCounter += 0.03f;
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
