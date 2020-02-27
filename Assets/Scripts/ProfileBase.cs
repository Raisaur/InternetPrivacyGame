﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProfileBase : MonoBehaviour
{
    public const int nr_of_tags = 7;
    List<TagBase> profile_tags;

    [SerializeField]
    //Order: gender, age, location, occupation, family, financial, searched
    VarRef.Tag[] tag_array = new VarRef.Tag[nr_of_tags];
    TagBase[] tag_bases = new TagBase[nr_of_tags];

    Dictionary<VarRef.Topic, int> points_ref;
    TagList tags;
    int upgrade_level;

    // Start is called before the first frame update

    void Start()
    {
        points_ref.Add(VarRef.Topic.TravelCruise, 0);
        points_ref.Add(VarRef.Topic.TravelCharter, 0);
        points_ref.Add(VarRef.Topic.TravelBudget, 0);
        
        points_ref.Add(VarRef.Topic.ElecPhone, 0);
        points_ref.Add(VarRef.Topic.ElecHouse, 0);
        points_ref.Add(VarRef.Topic.ElecGames, 0);

        points_ref.Add(VarRef.Topic.SportsFootball, 0);
        points_ref.Add(VarRef.Topic.SportsSkate, 0);
        points_ref.Add(VarRef.Topic.SportsHike, 0);

        points_ref.Add(VarRef.Topic.FoodQuick , 0);
        points_ref.Add(VarRef.Topic.FoodGourmet, 0);
        points_ref.Add(VarRef.Topic.FoodCafe, 0);

        points_ref.Add(VarRef.Topic.CarsBudget, 0);
        points_ref.Add(VarRef.Topic.CarsHighend, 0);
        points_ref.Add(VarRef.Topic.CarsParts, 0);

        points_ref.Add(VarRef.Topic.ClothesWomen, 0);
        points_ref.Add(VarRef.Topic.ClothesMen, 0);
        points_ref.Add(VarRef.Topic.ClothesCostume, 0);

        tags = GameObject.FindWithTag("GameController").GetComponent<TagList>();
        upgrade_level = GameObject.FindWithTag("GameController").GetComponent<GameManager>().upgrade_level;

        for (int i = 0; i < (int)VarRef.Tag.blank; i++){
            for (int j = 0; i < nr_of_tags; j++)
            {
                //If the tag currently investigated exists on this profile
                if (i == (int)tag_array[j])
                {
                    //Grab a reference to that base tag for easy access
                    tag_bases[j] = tags.tag_list[i];
                }
            }
        }

        for (int i = 0; i < nr_of_tags; i++)
        {
            //Check what topics are in this tag's tier 1 list
            for (int j = 0; j < tag_bases[i].tier1.Count; j++)
            {
                points_ref[tag_bases[i].tier1[j]] += 3;
            }
            //Check what topics are in this tag's tier 2 list
            for (int k = 0; k < tag_bases[i].tier2.Count; k++)
            {
                points_ref[tag_bases[i].tier2[k]] += 2;
            }
            //Check what topics are in this tag's tier 3 list
            for (int l = 0; l < tag_bases[i].tier3.Count; l++)
            {
                points_ref[tag_bases[i].tier3[l]] += 1;
            }
        }

        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public int GetNrOfTags()
    {
        return nr_of_tags;
    }

    public TagBase GetTagByIndex(int index)
    {
        return profile_tags[index];
    }
}
