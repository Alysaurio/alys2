using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int health = 100;
    
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void DamagetoEnemy(int damage)
    {
        health -= damage;
        if (health < 0)
        {
            health = 0;
            Debug.Log("Enemigo derrotado");
        }
       
    }

}
