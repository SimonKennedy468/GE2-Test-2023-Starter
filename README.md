# Game Engines Lab Test 2023

- [Submission Link](https://forms.office.com/Pages/ResponsePage.aspx?id=yxdjdkjpX06M7Nq8ji_V2ou3qmFXqEdGlmiD1Myl3gNUNEQ5MVdROEkxVlpQVVBLUU1GR0YxQzExOC4u)

In today's test you will be programming a system that allows a player to take control of a creature whenever the player enters a Pod attached to the creature. Below is a video of what the final system should look like:

[![Video](http://img.youtube.com/vi/2yy03ItDzlo/0.jpg)](http://www.youtube.com/watch?v=2yy03ItDzlo)

Some things to note: 

- The Pod is rotating.
- The Pod is attached to one of the segments of the creature.
- The player is in FPS mode when the scene starts.
- When the player enters the Pod, the players position will smoothly move to the center of the Pod.
- Also while in the Pod, the players rotation will smoothly rotate so that it faces forward, as per the video.
- While inside the Pod, movement is disabled and instead, WASD steers the creature.
- Pressing z releases the creature and it will go back to it's previous behavior.

## Instructions

- Fork this repository.
- Clone it to your computer.
- Start with either the Godot or Unity starter project in the repo. The repos contain all the Godot and Unity code from this year and last years Games Engines 2 courses, which you are free to reference and use in your solution.
- You can use either the [Godot reference](https://docs.godotengine.org/en/3.5/) or [Unity reference](https://docs.unity3d.com/ScriptReference/), but no other sources or references during the test.
- No collaboration or communication.
- Make regular, commented commits during the test. At least 5.
- At the end of the test, submit your git repo link.

Godot Users:

- Open the scene exam_creature.tscn
- Press p in the running game to pause the Boid's integration
- Press q to quit
- wasd to move
- There is a Docecehedron model in the models folder you can use
- There are behaviors on the Boid node inside the Creature node that you can enable and disable through the editor or code
- There is a scene called collision_test that shows how to detect a collision between a Kinematicbody and an Area

Unity User:

- Open the scene exam_creature
- There is a Docecehedron model in the models folder you can use

Marking Scheme:

| Marks | Description |
|-------|-------------|
| Making the Pod | 20 marks |
| Player interacting with the Pod | 20 marks |
| Controlling the creature | 10 marks |
| Releasing the creature by pressing z | 20 marks |
| git repo with 5 commits and 1 branch | 10 marks |
| Any other cool things | 20 marks | 