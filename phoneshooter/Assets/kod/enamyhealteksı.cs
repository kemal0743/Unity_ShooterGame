using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enamyhealteksı : MonoBehaviour
{
    public dusman enamy;
    public Image _healtbar;
    public float _currenthealt;
    public float _maxhealt;
    void Start()
    {
        enamy = GameObject.FindObjectOfType<dusman>();
    }

    // Update is called once per frame
    void Update()
    {
        _currenthealt = enamy.Healts;
        _healtbar.fillAmount = _currenthealt / _maxhealt;
    }
}
