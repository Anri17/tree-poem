using UnityEngine;

[CreateAssetMenu(fileName = "Poem", menuName = "Poem")]
public class Poem : ScriptableObject
{
    public string authorName;
    [TextArea(12,20)]
    public string poemText;
    public AudioClip poemVoice;
    public Sprite authorPhoto;
}
