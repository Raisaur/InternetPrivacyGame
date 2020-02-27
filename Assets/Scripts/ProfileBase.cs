using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProfileBase : MonoBehaviour
{
    public const int nr_of_tags = 7;
    TagBase gender_tag, age_tag, location_tag, occupation_tag, family_tag, financial_tag, searched_tag;
    List<TagBase> profile_tags;

    [SerializeField]
    VarRef.Tag gender, age, location, occupation, family, financial, searched;

    // Start is called before the first frame update
    void Start()
    {
        
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
