using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkReference : MScript
{
    private Reference reference;
    public Reference Reference { get => reference; set { reference = value;}}

    protected override void Awake()
    {
        reference = GetComponentInParent<Reference>();
    }
}
