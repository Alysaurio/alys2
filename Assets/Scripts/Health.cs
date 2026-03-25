using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int health = 100;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void TakeDamage(int daño)
    {
        health -= daño;
        if (health < 0)
        {
            health = 0; 
        }
    }
    public void Curarse(int cura)
    {
        health += cura; 
        if (health >100)
        {
            health=100;
        }
    }

}
