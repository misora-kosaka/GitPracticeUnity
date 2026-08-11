using UnityEngine;

namespace GitPracticeUnity
{
    public class Enemy : MonoBehaviour
    {
        [SerializeField] private int hitPoints = 10;
        [SerializeField] private float moveSpeed = 2.0f;

        public void Damage(int amount)
        {
            hitPoints = Mathf.Max(0, hitPoints - amount);
        }

        public void Move(Vector3 direction)
        {
            transform.position += direction * moveSpeed * Time.deltaTime;
        }
    }
}
