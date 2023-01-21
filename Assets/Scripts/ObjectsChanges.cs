using UnityEngine;

public class ObjectsChanges : MonoBehaviour
{
    [SerializeField] private GameObject[] _objects;
    [SerializeField] private Inputs _inputs;
    private int _currentIndex = 0;

    private void Start()
    {
        _objects[_currentIndex].SetActive(true);
        _inputs.MouseWheelUp += Change;
    }

    private void Change(bool up)
    {
        _objects[_currentIndex].SetActive(false);
        
        if (up)
        {
            if (_currentIndex +1 >= _objects.Length)
            {
                _currentIndex = 0;
            }
            else
            {
                _currentIndex++;
            }
        }
        else
        {
            if (_currentIndex -1 < 0)
            {
                _currentIndex = _objects.Length - 1;
            }
            else
            {
                _currentIndex--;
            }
        }

        _objects[_currentIndex].SetActive(true);
    }
}
