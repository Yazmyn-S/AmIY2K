using UnityEngine;

public class GameFairyAni : MonoBehaviour
{
    [Header("Animation Reference")]
    [SerializeField] private Animation fairyAnimation;

    [Header("Animation Clip")]
    [SerializeField] private AnimationClip idleFairy;

    private void Start()
    {
        if (fairyAnimation == null)
        {
            fairyAnimation = GetComponent<Animation>();
        }

        if (fairyAnimation && idleFairy != null)
        {
            fairyAnimation.AddClip(idleFairy, "Idle_Clip");
            fairyAnimation.Play("Idle_Clip");
        }
        else
        {
            Debug.LogError("Animation component or clip is missing.");
        }
    }
}
