using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] private int damage;
    [SerializeField] private int ammo = 10;
    void Start()
    {
        
    }


    public void Shoot(Player target)
    {
        if (target == null || ammo == 0)
            return;

        if (ammo > 0)
        {
            target.TakeDamage(damage);
            ammo--;
            Debug.Log("Shoot");
        }
        else
        {
            Debug.Log("Sin munición");
        }
        
        
    }
    public void ShootEnemy(Enemy target)
    {
        if (target == null || ammo == 0)
            return;

        if (ammo > 0)
        {
            target.DamagetoEnemy(damage);
            ammo--;
            Debug.Log("Enemigo disparado");
        }
        else
        {
            Debug.Log("Sin munición");
        }


    }

}
