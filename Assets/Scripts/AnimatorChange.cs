using UnityEngine;

public class AnimatorChange : MonoBehaviour
{
    [SerializeField] private Animator _psyAnimator;
    [SerializeField] private Inputs _inputs;

    private string[] _anims = new string[] { "active1", "active2", "active3", "active4", "active5" };

    private void Start()
    {
        _inputs.InputKeyBoard1 += ActiveAnimate;
        _inputs.InputKeyBoard2 += ActiveAnimate;
        _inputs.InputKeyBoard3 += ActiveAnimate;
        _inputs.InputKeyBoard4 += ActiveAnimate;
        _inputs.InputKeyBoard5 += ActiveAnimate;
    }

    private void ActiveAnimate(string name)
    {
        DeActiveAnimate();
        _psyAnimator.SetBool(name, true);
    }

    private void DeActiveAnimate()
    {
        for (int i = 0; i < _anims.Length; i++)
        {
            _psyAnimator.SetBool(_anims[i], false);
        }
    }
}
