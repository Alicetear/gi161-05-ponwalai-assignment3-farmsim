using UnityEngine;

public class Chicken : Abstractanimal
{

    private int eggs;

    public int Eggs
    {
        get { return eggs; }
        set
        {
            if (value > 0) eggs = 0;
            else eggs = value;
        }
    }


    public override void Init(string newName, int newHunger, int Happiness)
    {
        base.Init(newName, newHunger, Happiness);
        Eggs = 0;
    }



    public override void MakeSound()
    {
        base.MakeSound();
        Happiness += 10;
        Debug.Log($"{name} say cock-a-doodle-doo!");
    }






    public void Sleep() 
    {
        Hunger += 5;
        Happiness += 10;
        Debug.Log($"{name} are sleeping, their happiness and food value increase!");

    }





















}
