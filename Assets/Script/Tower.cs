using UnityEngine;
using System.Collections.Generic;

public class Tower : MonoBehaviour
{
    public GameObject _upgrade = null;
    private GameObject upgrade { get { return _upgrade; } }

    private float fireRate { get; set; } = 1.0f;
    private float currentFireRate { get; set; } = 0.0f;

    private List<Enemy> enemies { get; set; } = null;

    private void Start()
    {
        enemies = new List<Enemy>();
    }

    private void Update()
    {
        
    }

    public void Upgrade()
    {
        if (upgrade == null)
        {
            return;
        }

        Instantiate(upgrade, transform.position, transform.rotation);
        Destroy(gameObject);
    }

    

    public void AddEnemy(Enemy enemy)
    {
        enemies.Add(enemy);
    }

    public void RemoveEnemy(Enemy enemy)
    {
        enemies.Remove(enemy);
    }
}
