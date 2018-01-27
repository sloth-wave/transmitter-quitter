using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Channel : IChannelBase{

    public void Win() {

    }

    public void Lose() {

    }
}

public interface IChannel : IChannelBase{
    void Generate();
    void CleanUp();
}

public interface IChannelBase {
    void Win();
    void Lose();
}
