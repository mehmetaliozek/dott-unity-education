using System.Collections;
using UnityEngine;

[System.Serializable]
public class Knockback
{
    [HideInInspector]
    public bool isKnockback;

    [SerializeField]
    private float knockbackingPower = 10f;
    [SerializeField]
    private float knockbackingTime = 0.2f;

    public IEnumerator KnockbackCoroutine(Rigidbody2D rb, Vector3 direction)
    {
        isKnockback = true;
        Vector3 force = direction.normalized * knockbackingPower;
        rb.AddForce(force, ForceMode2D.Impulse);

        yield return new WaitForSeconds(knockbackingTime);
        isKnockback = false;
    }
}