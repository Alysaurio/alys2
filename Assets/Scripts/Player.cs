using UnityEngine;

public class Player : MonoBehaviour
{
    public Player TARGET;
    public Enemy ENEMYTARGET;
    [SerializeField] private string PlayerName;
    private Health health = new();
    [SerializeField] private Weapon weapon;
    [SerializeField] private int healvalue;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot(TARGET);
            ShootEnemy(ENEMYTARGET);
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            Debug.Log(PlayerName + "|" + health.GetLife());
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            health.Heal(healvalue);
            Debug.Log("Vida restaurada!");
        }
    }

    public void TakeDamage( int damage) => health.TakeDamage( damage );

    public void Shoot(Player target)
    {
        weapon.Shoot( target );
    }
    public void ShootEnemy(Enemy target)
    {
        weapon.ShootEnemy( target );
    }
}
