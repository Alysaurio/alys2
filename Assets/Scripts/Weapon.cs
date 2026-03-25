using UnityEngine;

public class Weapon : MonoBehaviour
{
    public int damage;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void Attack(Health target)
    {
        target.TakeDamage(damage);
    }

}
