using System;
using UnityEngine;
using UnityEngine.Events;

public class Fighter : MonoBehaviour
{
    [SerializeField]
    private String _name;
    public String Name => _name;
    [SerializeField]
    private Health _health;

    [SerializeField]
    private Animator _characterAnimator;

    [SerializeField]
    private Attacks _attacks;
    public Attacks Attacks => _attacks;
    public Health Health => _health;
    public Animator CharacterAnimator => _characterAnimator;
    [SerializeField]
    private UnityEvent _onFighterInitialized;
    [SerializeField]
    private string _winAnimationName = "Win";
    public string WinAnimationName => _winAnimationName;

    [SerializeField]
    private string _winSoundName = "WinSound";
    public string WinSoundName => _winSoundName;

    public void InitializeFighter()
    {
        _onFighterInitialized?.Invoke();
    }
}
