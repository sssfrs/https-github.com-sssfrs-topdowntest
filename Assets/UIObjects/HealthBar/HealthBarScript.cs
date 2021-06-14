using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBarScript : MonoBehaviour
{
    private Transform fill;

    void Start()
    {
        fill = transform.Find("FillParent");
    }

    public void SetSize(float fillNormalized)
    {
        fill.localScale = new Vector3(fillNormalized, 1f);
    }
}
