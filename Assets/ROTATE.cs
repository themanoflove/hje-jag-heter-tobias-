﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ROTATE : MonoBehaviour {
    
public void CoolRotate(float degrees)
    {
        transform.Rotate(0, 0, degrees);
    }
}
