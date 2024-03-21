using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FactionLoginScreen : MonoBehaviour
{
    public Button signWithMatrica;
    public Button signWithDiscord;

    private void Awake()
    {
        signWithMatrica.onClick.AddListener(OnClickedSignInMatrica);
        signWithDiscord.onClick.AddListener(OnClickedSignInDiscord);
    }

    private void OnClickedSignInDiscord()
    {

    }

    private void OnClickedSignInMatrica()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
