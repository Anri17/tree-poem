using UnityEngine;

[CreateAssetMenu(fileName = "Poem", menuName = "Poem")]
public class Poem : ScriptableObject
{
    public string authorName;
    [TextArea]
    public string poemText;
    public AudioClip poemVoice;
    public Sprite authorPhoto;
}
