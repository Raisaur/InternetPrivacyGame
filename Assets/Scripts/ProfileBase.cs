using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProfileBase : MonoBehaviour
{
    public const int nr_of_tags = 7;
    List<TagBase> profile_tags;

    [SerializeField]
    VarRef.Tag gender, age, location, occupation, family, financial, searched;
    TagBase gender_tag, age_tag, location_tag, occupation_tag, family_tag, financial_tag, searched_tag;

    Dictionary<VarRef.Topic, int> points_ref;
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

        upgrade_level = GameObject.FindWithTag("GameController").GetComponent<GameManager>().upgrade_level;


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
