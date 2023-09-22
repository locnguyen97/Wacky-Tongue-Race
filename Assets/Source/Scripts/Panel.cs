using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel : MonoBehaviour
{
    [SerializeField] private GameObject real;
    [SerializeField] private GameObject fake;
    // Start is called before the first frame update
    void Start()
    {
        real.SetActive(false);
        fake.SetActive(true);
    }

    public void Show()
    {
        real.SetActive(true);
        fake.SetActive(false);
        
    }
}
