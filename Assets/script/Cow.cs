using UnityEngine;

public class Cow : Abstractanimal
{

    private float milk;

    public float Milk
    {
        get { return Milk; }
        set
        {
            if (value > 0) Milk = 0;
            else Milk = value;
        }
    }

    public override void MakeSound()
    {
        base.MakeSound();
        Happiness += 10;
        Debug.Log($"{name} say Moo!");
    }



    public void Moo()
    {
        Happiness += 10;
        Debug.Log($"{name} say moo!, happiness increase!");

    }
























}
