using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProfileBase 
{
    public const int nr_of_tags = 7;
    List<TagBase> profile_tags;

    [HideInInspector]
    //Order: gender, age, location, occupation, family, financial, searched
    public VarRef.Tag[] tag_array;
    TagBase[] tag_bases;

    [HideInInspector]
    public Dictionary<VarRef.Topic, int> points_ref;
    TagList tags;
    int upgrade_level;

    public ProfileBase(VarRef.Tag p_gen, VarRef.Tag p_age, VarRef.Tag p_loc,
                VarRef.Tag p_occ, VarRef.Tag p_fam, VarRef.Tag p_fin, VarRef.Tag p_srch)
    {
        tag_array = new VarRef.Tag[nr_of_tags];

        tag_array[0] = p_gen; tag_array[1] = p_age;
        tag_array[2] = p_loc; tag_array[3] = p_occ;
        tag_array[4] = p_fam; tag_array[5] = p_fin;
        tag_array[6] = p_srch;

        points_ref = new Dictionary<VarRef.Topic, int>();
        tag_bases = new TagBase[nr_of_tags];
        tags = new TagList();

        points_ref.Add(VarRef.Topic.TravelCruise, 0);
        points_ref.Add(VarRef.Topic.TravelCharter, 0);
        points_ref.Add(VarRef.Topic.TravelBudget, 0);
        
        points_ref.Add(VarRef.Topic.ElecPhone, 0);
        points_ref.Add(VarRef.Topic.ElecHouse, 0);
        points_ref.Add(VarRef.Topic.ElecGames, 0);

        points_ref.Add(VarRef.Topic.SportsFootball, 0);
        points_ref.Add(VarRef.Topic.SportsSwimwear, 0);
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

        upgrade_level = GameObject.FindWithTag("GameController").GetComponent<GameManager>().upgrade_level;

        for (int i = 0; i < (int)VarRef.Tag.blank; i++){
            for (int j = 0; j < nr_of_tags; j++)
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

    public int GetNrOfTags()
    {
        return nr_of_tags;
    }

    public TagBase GetTagByIndex(int index)
    {
        return profile_tags[index];
    }

    public VarRef.Tag[] GetTagArray()
    {
        return tag_array;
    }
}
