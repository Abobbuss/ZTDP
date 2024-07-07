using UnityEngine;
using UnityEngine.Events;

public class PlayerMainer : Unit, IPlayerObj
{
    [SerializeField] private float _maxHealth;
    
    private IPlayerObj _target;
    private float _currentHealth;

    public IPlayerObj Target => _target;

    public event UnityAction<PlayerMainer> Dying;

    public override void TakeDamage(float damage)
    {
        _currentHealth -= damage;

        if (_currentHealth <= 0)
        {
            Dying?.Invoke(this);
            Destroy(gameObject);
        }
    }

    public override void HealDamage(float damage)
    {
        if (_currentHealth < _maxHealth)
            _currentHealth += damage;
    }
}
