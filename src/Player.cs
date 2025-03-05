
class Player
{
    // fields
    private int health;
    // auto property
    public Room CurrentRoom { get; set; }
    public int GetHealth { get; set; }

    // constructor
    public Player()
    {
        CurrentRoom = null;
        health = 100;

    }

    // methods
    public int Damage(int amount) // player loses some health
    {
        this.health -= amount;
        if (this.health < 0) this.health = 0;
        return this.health;
    }


    public int Heal(int amount) // player's health restores
    {
        this.health += amount;
        if (this.health > 100) this.health = 100;
        return this.health;
    }
    public bool IsAlive() // checks whether the player is alive or not
    {
        return this.health > 0;

    }


    public string GetStatus()
    {
        string str = "You have ";
        str += this.health;
        str += ".\n";
        return str;
    }


}