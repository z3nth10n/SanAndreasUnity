
## About weapons implementation
<br>


Loading weapons is easy, just load weapons.dat, and their models, and that's pretty much it.
<br>


***
<br>


What is difficult, is to integrate weapons with animations.

We need the following functionality:

- When player aims, he needs to switch to another anim, and he needs to **lean his head** (how to do this, is there a separate anim for this ?). - Found the anims that were needed.

- When player aims, his head and hands should rotate in that direction (including up and down), so we would need to somehow **rotate spine** or something

- When player has a weapon in his hand, the **weapon should be attached to fingers** (maybe with a little adjustment for fingers) - this way player can do all anims (jump, run, etc), and weapon will remain on the proper place. This should only be done for specific anims.

- There are cases when we need to **play 2 anims at the same time**. Examples: reloading a weapon, aim and move at the same time. How to do this ? Tried with anim blending, but it looked ugly. Try avatar mask ?


***

Each weapon has it's own anim group. So, anims will be played based on what weapon is held.

But **how to determine position of weapon ?** Each weapon has firing offset, and aiming offset (maybe this is actually the position of weapon). - This can be done by testing.

**Where to place hands ?** There is nothing in weapons.dat saying about this. Is it hardcoded ? Or shall we just play weaponaim anim, and somehow adjust hands/fingers based on type of the weapon (or his aim offset) ? - Looks like that this is handled by anim.

***

These are the useful parameters in weapons.dat :

- fire offset (this could be just the location of bullet when it's fired ?)
- aim offset (this could be position of weapon when it's held, or position of where the other hand should be ?)
- anim group

***

### TODO

- fire : aim anim will loop ; gun flash needs some anim (or just rotate it)

- play 2 anims at the same time - this is needed for: reloading, aim and move at the same time, 

- problematic anims: move/fire with heavy weapons, 

- when aiming with single-arm weapons - play the same idle anim for all models ?

- spine should be rotated locally, not globally ? - some models have different rotation of spine in the idle anim, which means that their spine will not look at the same place - possible solution would be to play the same idle anim on all models

- whem anim is changed, reset model state

- right after the model is loaded, reset model state

- rotate the pelvis instead of spine (because thighs look ugly)

- run and aim at the same time with single-arm weapons

- walk and aim at the same time ; strafe ;

- play separate anim for: minigun and flame thrower, 

