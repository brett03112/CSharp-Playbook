/*
*
*   Notes from level 25 Inheritance.
*
*/

public class GameObject
{
    public float PositionX { get; protected set; }
    public float PositionY { get; protected set; }
    public float VelocityX { get; protected set; }
    public float VelocityY { get; protected set; }

     /// <summary>
        /// Initializes a new instance of the <see cref="GameObject"/> class.
        /// Sets the initial position and velocity of the game object.
    /// </summary>
    public GameObject()
    {
        PositionX = 2;
        PositionY = 3;
        VelocityX = 1;
        VelocityY = 1;
    }

    public void Update()
    {
        PositionX += VelocityX;
        PositionY += VelocityY;
    }
}

public class Asteroid : GameObject
{
    public float Size { get;  }
    public float RotationAngle { get; }

    /// <summary>
        /// Initializes a new instance of the <see cref="Asteroid"/> class.
        /// Sets the size, rotation angle, velocity, and position of the asteroid.
    /// </summary>
    public Asteroid()
    {
        Size = 10;
        RotationAngle = -1;

        VelocityX = 1;
        VelocityY = 1;

        PositionX = 2;
        PositionY = 3;
    }
    /// <summary>
        /// Initializes a new instance of the <see cref="Asteroid"/> class with the specified position and velocity.
    /// </summary>
        /// <param name="positionX">The X-coordinate of the asteroid's position.</param>
        /// <param name="positionY">The Y-coordinate of the asteroid's position.</param>
        /// <param name="velocityX">The X-component of the asteroid's velocity.</param>
        /// <param name="velocityY">The Y-component of the asteroid's velocity.</param>
    public Asteroid(float positionX, float positionY, float velocityX, float velocityY) : base(positionX, positionY, velocityX, velocityY)
    {
        // Add any extra initialization code here
    }
    
    /// <summary>
        /// Updates the object by calling the base class's Update method.
    /// </summary>
    public override void Update()
    {
        base.Update();
    }
}
