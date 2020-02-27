using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TagBase : MonoBehaviour
{
    public VarRef.Tag this_tag;

    List<VarRef.Topic> tier1;
    List<VarRef.Topic> tier2;
    List<VarRef.Topic> tier3;

    void Start()
    {
        
    }
}

public class TagList : MonoBehaviour
{
    public List<TagBase> tag_list;

    void Start()
    {
        TagBase NewTag;

        for (int i = 0; i < (int)VarRef.Tag.blank; i++)
        {

        }
    }
}