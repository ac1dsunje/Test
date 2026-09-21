using UnityEngine;

namespace _Project.Scripts
{
public class Test : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("ИЛЮХА ПРИВЕТ!!!");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log($"{Time.deltaTime} времени прошло с прошлого кадра");
    }
}
}
