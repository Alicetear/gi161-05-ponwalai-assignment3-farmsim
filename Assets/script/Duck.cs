using UnityEngine;

public class Duck : Abstractanimal
{
    public override void MakeSound()
    {
        base.MakeSound();
        Happiness += 10;
        Debug.Log($"{name} say quack!");
    }


    public override void Init(string newName, int newHunger, int Happiness)
    {
        base.Init(newName, newHunger, Happiness);

    }





}
