using UnityEngine;

public class Health
{
    [SerializeField] private int value = 100;
   
    public void TakeDamage(int daño)
    {
        value -= daño;
        if (value < 0)
        {
            value = 0; 
        }
    }
    public int GetLife()
    {
        return value
    }
    public void Curarse(int cura)
    {
        value += cura; 
        if (value >100)
        {
            value=100;
        }
    }

}
