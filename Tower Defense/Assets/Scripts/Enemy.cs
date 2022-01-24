using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    [HideInInspector] public float speed;
    public float startSpeed = 10f;
    public float startHealth = 100;
    public int moneyReward = 25;

    private float health;

    private bool isDead = false;

    [Header("Unity Stuff")]
    public GameObject deathEffect;
    public Image healthBar;

    private void Start()
    {
        speed = startSpeed;
        health = startHealth;
    }
    public void TakeDamage(float amount)
    {
        health -= amount;

        healthBar.fillAmount = health / startHealth;

        if (health <= 0 && !isDead)
        {
            Die();
        }
    }
    public void Slow(float amount)
    {
        speed = startSpeed * (1f - amount);
    }
    private void Die()
    {
        isDead = true;

        PlayerStats.Money += moneyReward;
        GameObject effect = (GameObject)Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(effect, 5f);

        WaveSpawner.EnemiesAlive--;

        Destroy(gameObject);
    }
}
