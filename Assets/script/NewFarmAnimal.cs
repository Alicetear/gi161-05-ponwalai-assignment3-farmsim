using UnityEngine;

public class NewFarm : Abstractanimal
{
    public override void MakeSound()
    {
        base.MakeSound();
        Happiness += 10;
        Debug.Log($"{name} croak, happiness increases.");
    }
}
