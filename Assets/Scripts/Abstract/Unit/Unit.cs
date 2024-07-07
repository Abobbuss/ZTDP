using UnityEngine;

public abstract class Unit : MonoBehaviour, IUnit
{
    public string Name {  get; private set; }

    public abstract void TakeDamage(float damage);
    public abstract void HealDamage(float damage);
}
