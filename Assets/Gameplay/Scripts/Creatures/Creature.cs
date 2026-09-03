using UnityEngine;

public abstract class Creature : MonoBehaviour
{
    public virtual void Death()
    {
        Destroy(gameObject);
    }
}
