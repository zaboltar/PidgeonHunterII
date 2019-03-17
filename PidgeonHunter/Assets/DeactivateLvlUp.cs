using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateLvlUp : MonoBehaviour
{
  void RecycleLevelUpMsg ()
    {
        gameObject.SetActive(false);
    }
}
