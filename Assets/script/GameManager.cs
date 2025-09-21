using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;

public class GameManager : MonoBehaviour
{
    public List<string> AnimalName = new List<string> { "Chicken", "Cow", "Cat" };
    public List<Abstractanimal> Newfarmanimal;
    public Cow Cow;
    public Chicken Chicken;
    public Duck duck;
    void Start()
    {
        Debug.Log(" *** | Welcome to Happy Farm Sim |  ***");
        Debug.Log($" = There are {AnimalName.Count} in the Happy Farm = ");



        Cow.Init ("mona" ,14 ,14);
        Newfarmanimal.Add(Cow);

        Chicken.Init("tiggy", 17, 20);
        Newfarmanimal.Add(Chicken);

        duck.Init("pow", 12, 10);
        Newfarmanimal.Add(duck);



        foreach (var animal in Newfarmanimal)
        {
            animal.GetStatus();
        }



        foreach (var feedanimal in Newfarmanimal)
        {
            feedanimal.MakeSound();
            feedanimal.Feed(6);
        }

        Chicken.Feeds("popo",8);
        Chicken.Sleep();
        Chicken.GetStatus();

        Cow.Feeds("wiggy", 7);
        Cow.Moo();
        Cow.GetStatus();

        duck.Feeds("Jay",6);
        duck.GetStatus();










        /*Chicken chicken = new Chicken(" Chicken " , 0);

        Cow cow = new Cow (" Cow ", 0);


        Debug.Log("|  *** Welcome to Animal Farm! ***  |");





        chicken.GetStatus();
        chicken.AdjustHunger(-20);
        chicken.AdjustHappiness(10);
        chicken.MakeSound();
        chicken.Feed("");
        chicken.GetStatus();
        chicken.AdjustHunger(12);
        chicken.AdjustHappiness(-18);
        chicken.Sleep();
        chicken.GetStatus();



        cow.GetStatus();
        cow.AdjustHunger(-7);
        cow.AdjustHappiness(10);
        cow.MakeSound();
        cow.Feed("");
        cow.GetStatus();
        cow.Moo();
        cow.AdjustHunger(5);
        cow.Feed("          ");
        cow.Moo();
        cow.GetStatus();*/













    }



}
