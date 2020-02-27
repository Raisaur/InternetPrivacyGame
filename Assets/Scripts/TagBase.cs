using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TagBase : MonoBehaviour
{
    public VarRef.Tag this_tag;

    public List<VarRef.Topic> tier1;
    public List<VarRef.Topic> tier2;
    public List<VarRef.Topic> tier3;

    void Start()
    {
        
    }
}

public class TagList : MonoBehaviour
{
    public List<TagBase> tag_list;

    void Start()
    {

        for (int i = 0; i < (int)VarRef.Tag.blank; i++)
        {
            TagBase NewTag = new TagBase();
            NewTag.this_tag = (VarRef.Tag)i;
            tag_list.Add(NewTag);
        }

        {
            tag_list[(int)VarRef.Tag.GenWoman].tier3.Add(VarRef.Topic.ClothesWomen);
            tag_list[(int)VarRef.Tag.GenWoman].tier3.Add(VarRef.Topic.ElecPhone);
            tag_list[(int)VarRef.Tag.GenWoman].tier3.Add(VarRef.Topic.FoodCafe);
            tag_list[(int)VarRef.Tag.GenWoman].tier3.Add(VarRef.Topic.TravelCharter);
            tag_list[(int)VarRef.Tag.GenWoman].tier3.Add(VarRef.Topic.TravelBudget);
            tag_list[(int)VarRef.Tag.GenWoman].tier3.Add(VarRef.Topic.FoodQuick);
            tag_list[(int)VarRef.Tag.GenWoman].tier3.Add(VarRef.Topic.FoodGourmet);
        }

        {
            tag_list[(int)VarRef.Tag.GenMan].tier3.Add(VarRef.Topic.ClothesMen);
            tag_list[(int)VarRef.Tag.GenMan].tier3.Add(VarRef.Topic.ElecGames);
            tag_list[(int)VarRef.Tag.GenMan].tier3.Add(VarRef.Topic.SportsFootball);
            tag_list[(int)VarRef.Tag.GenMan].tier3.Add(VarRef.Topic.SportsSkate);
            tag_list[(int)VarRef.Tag.GenMan].tier3.Add(VarRef.Topic.CarsBudget);
            tag_list[(int)VarRef.Tag.GenMan].tier3.Add(VarRef.Topic.CarsHighend);
            tag_list[(int)VarRef.Tag.GenMan].tier3.Add(VarRef.Topic.CarsParts);
            tag_list[(int)VarRef.Tag.GenMan].tier3.Add(VarRef.Topic.FoodQuick);
        }

        {
            tag_list[(int)VarRef.Tag.AgeChild].tier3.Add(VarRef.Topic.ElecGames);
            tag_list[(int)VarRef.Tag.AgeChild].tier3.Add(VarRef.Topic.ElecPhone);
            tag_list[(int)VarRef.Tag.AgeChild].tier3.Add(VarRef.Topic.SportsFootball);
            tag_list[(int)VarRef.Tag.AgeChild].tier3.Add(VarRef.Topic.SportsSkate);
            tag_list[(int)VarRef.Tag.AgeChild].tier3.Add(VarRef.Topic.FoodCafe);
            tag_list[(int)VarRef.Tag.AgeChild].tier3.Add(VarRef.Topic.ClothesCostume);
        }

        {
            tag_list[(int)VarRef.Tag.AgeAdult].tier3.Add(VarRef.Topic.TravelCharter);
            tag_list[(int)VarRef.Tag.AgeAdult].tier3.Add(VarRef.Topic.ElecPhone);
            tag_list[(int)VarRef.Tag.AgeAdult].tier3.Add(VarRef.Topic.ElecHouse);
            tag_list[(int)VarRef.Tag.AgeAdult].tier3.Add(VarRef.Topic.FoodCafe);
            tag_list[(int)VarRef.Tag.AgeAdult].tier3.Add(VarRef.Topic.TravelBudget);
            tag_list[(int)VarRef.Tag.AgeAdult].tier3.Add(VarRef.Topic.TravelCruise);
            tag_list[(int)VarRef.Tag.AgeAdult].tier3.Add(VarRef.Topic.FoodGourmet);
            tag_list[(int)VarRef.Tag.AgeAdult].tier3.Add(VarRef.Topic.FoodQuick);
        }

        {
            tag_list[(int)VarRef.Tag.AgeElderly].tier3.Add(VarRef.Topic.TravelCharter);
            tag_list[(int)VarRef.Tag.AgeElderly].tier3.Add(VarRef.Topic.ElecHouse);
            tag_list[(int)VarRef.Tag.AgeElderly].tier3.Add(VarRef.Topic.FoodGourmet);
            tag_list[(int)VarRef.Tag.AgeElderly].tier3.Add(VarRef.Topic.FoodCafe);
            tag_list[(int)VarRef.Tag.AgeElderly].tier3.Add(VarRef.Topic.SportsHike);
            tag_list[(int)VarRef.Tag.AgeElderly].tier3.Add(VarRef.Topic.CarsParts);
        }

        {
            tag_list[(int)VarRef.Tag.LiveCity].tier3.Add(VarRef.Topic.TravelCharter);
            tag_list[(int)VarRef.Tag.LiveCity].tier3.Add(VarRef.Topic.ElecPhone);
            tag_list[(int)VarRef.Tag.LiveCity].tier3.Add(VarRef.Topic.ElecHouse);
            tag_list[(int)VarRef.Tag.LiveCity].tier3.Add(VarRef.Topic.FoodQuick);
            tag_list[(int)VarRef.Tag.LiveCity].tier3.Add(VarRef.Topic.FoodGourmet);
            tag_list[(int)VarRef.Tag.LiveCity].tier3.Add(VarRef.Topic.FoodCafe);
            tag_list[(int)VarRef.Tag.LiveCity].tier3.Add(VarRef.Topic.CarsHighend);
        }

        {
            tag_list[(int)VarRef.Tag.LiveCountry].tier3.Add(VarRef.Topic.TravelBudget);
            tag_list[(int)VarRef.Tag.LiveCountry].tier3.Add(VarRef.Topic.ElecPhone);
            tag_list[(int)VarRef.Tag.LiveCountry].tier3.Add(VarRef.Topic.SportsFootball);
            tag_list[(int)VarRef.Tag.LiveCountry].tier3.Add(VarRef.Topic.SportsSkate);
            tag_list[(int)VarRef.Tag.LiveCountry].tier3.Add(VarRef.Topic.SportsHike);
            tag_list[(int)VarRef.Tag.LiveCountry].tier3.Add(VarRef.Topic.CarsBudget);
        }

        {
            tag_list[(int)VarRef.Tag.OccStudent].tier2.Add(VarRef.Topic.TravelBudget);
            tag_list[(int)VarRef.Tag.OccStudent].tier2.Add(VarRef.Topic.ElecHouse);
            tag_list[(int)VarRef.Tag.OccStudent].tier2.Add(VarRef.Topic.FoodQuick);
            tag_list[(int)VarRef.Tag.OccStudent].tier2.Add(VarRef.Topic.FoodCafe);
        }
    }
}