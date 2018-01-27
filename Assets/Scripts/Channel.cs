using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Channel {
    void Generate();
    void CleanUp();
    void Win();
    void Lose();
}
