using UnityEngine;

public class Jelly
{
    [SerializeField]
    private int id;
    public int Id => id;
    [SerializeField]
    private int level;
    public int Level => level;
    [SerializeField]
    private float exp;
    public float Exp => exp;

    public Jelly(int id, int level, float exp)
    {
        this.id = id;
        this.level = level;
        this.exp = exp;
    }
}
