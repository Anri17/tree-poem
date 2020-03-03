using UnityEngine;

[CreateAssetMenu(fileName = "Poem", menuName = "Poem")]
public class Poem : ScriptableObject
{
    public string authorName;
    public string authorClassNumber;
    public string authorClass;
    [TextArea]
    public string poemText;
    public AudioClip poemVoice;
    public Sprite authorPhoto;
}
