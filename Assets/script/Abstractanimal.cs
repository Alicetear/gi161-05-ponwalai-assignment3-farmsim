using UnityEngine;

public abstract class Abstractanimal : MonoBehaviour //abstract can't use to construct  obj only for inherit
{

    private string Name;


    private int hunger;

    public int Hunger
    {
        get { return hunger; }
        set
        {
            if (value < 0) hunger = 0;
            else if (value > 50) hunger = 50;
            else hunger = value;

        }
    }


    private int happiness;

    public int Happiness
    {
        get { return happiness; }
        set
        {
            if (value < 0) hunger = 0;
            else if (value > 50) happiness = 50;
            else happiness = value;
        }
    }




    public virtual void Init(string newName, int newHunger , int Happiness)
    {
        name = newName;
        hunger = newHunger;
        happiness = Happiness;
        
    }
    public virtual void MakeSound()
    {
        Debug.Log($"The animal is making noises.");

    }

    public void AdjustHunger(int Amount)
    {
        hunger += Amount;
        Debug.Log($"Your {name} are hungry.");

    }
    public void AdjustHappiness(int amount)
    {
        happiness += amount;
        Debug.Log($"The happiness value of the {name} is decreasing.");

    }


    


    public void Feed(int feed)
    {
        happiness += feed;
        hunger -= feed;
        Debug.Log($"{name} are fed, increasing their happiness and food {feed}");
    }

    public void Feeds (string AnimalFeed , int feedAnimal)
    {
        happiness += feedAnimal;
        hunger -= feedAnimal;
        Debug.Log($"{name} was fed {AnimalFeed} units of food {feedAnimal}.");
    }


    public void GetStatus()
    {
        Debug.Log($" Name : {name} | Hunger : {hunger} | Happiness : {happiness} |");
    }















   










}
