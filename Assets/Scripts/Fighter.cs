using UnityEngine;

public class Fighter : MonoBehaviour
{
    [SerializeField]
    private Attacks _attacks;

    [SerializeField]
    private Health _health;

    [SerializeField]
    private Animator _characterAnimator;

    public Health Health => _health;

    public Attacks Attacks => _attacks;

    public Animator CharacterAnimator => _characterAnimator;
}
