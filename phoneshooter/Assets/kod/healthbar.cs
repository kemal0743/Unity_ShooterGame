using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthbar : MonoBehaviour
{
    private karakter_ontrol player_;
    public Image _heatbar;
    public float _currenthealt;
    public float _maxhealt;
    void Start()
    {
        player_ = GameObject.FindObjectOfType<karakter_ontrol>();
    }

    // Update is called once per frame
    void Update()
    {
        _currenthealt = player_.health;
        _heatbar.fillAmount = _currenthealt - _maxhealt;
    }
}
