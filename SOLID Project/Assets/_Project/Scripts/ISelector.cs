using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public interface ISelector
{
    public void Check(Ray ray);
    public Transform GetSelection();
}