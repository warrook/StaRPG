# StaRPG
A mild RPG similar to Stick RPG, with some basic tasks, basic alterations to those tasks, and most importantly a time system (with discrete steps that advance when performing an action set to advance a step or two)

# Systems in order of complexity
- [Character Attributes](#character-attributes)
- [Activities that use, increase, and/or decrease attributes](#activities-that-use-increase-andor-decrease-attributes)
- [Time wedges, things that use time](#time-wedges-things-that-use-time)
    - [Rolling over time, tracking days](#rolling-over-time-tracking-days)
- [Integration of activities into the game world](#integration-of-activities-into-the-game-world)
- [Yarn integration](#yarn-integration)
- [Inventory](#inventory)
- [Any minigames](#any-minigames)
- [World design](#world-design)
- [Character movement via WASD over terrain with obstacles (buildings, walls, etc).](#character-movement-via-wasd-over-terrain-with-obstacles-buildings-walls-etc)
    - [Alterations to character movement, such as sprinting or riding a vehicle (Stick RPG's skateboard)](#alterations-to-character-movement-such-as-sprinting-or-riding-a-vehicle-stick-rpgs-skateboard)

# Systems Elaborated
## Character Attributes
Stick RPG employs 3 attributes: Intelligence, Strength, and Charm. There is no upper limit on these, and Strength appears to be the only one that has a scalar effect (granting higher prowess and greater abilities in bar fights). The others are thresholds or barriers.

For this game, there could be regardless of theme:
- A physical attribute, be it Strength, Athletics, Physical Education, Physical.
- A mental attribute, such as Intelligence, Smarts.
- A charisma attribute, such as Charisma, Charm, Willpower.
- A health attribute, such as Constitution, Healthiness, Endurance.
- A wisdom attribute, such as Wisdom, Street Smarts.
- A creativity attribute, such as Creativity, Inspiration.
- A knowledge attribute, such as Knowledge, History, Learning.

Kitty suggested a high school (anime or not) theme. Were that the case, attributes could be based on classes.

> [*Daily Life in Japanese High Schools*, Stanford](https://spice.fsi.stanford.edu/docs/daily_life_in_japanese_high_schools#:~:text=Students%20in%20academic%20high%20schools,level%20study%20the%20same%20subjects.)
>
> Students in academic high schools typically take three years each of the following subjects: mathematics, social studies, Japanese, science, and English. Other subjects include physical education, music, art, and moral studies. All the students in one grade level study the same subjects.

Therefore, the attributes could be these. Crossed out ones are perhaps unnecessary and could be lumped into another since there are a lot of them.
- Logic, for mathematics; 'rational' actions.
- Learning, for social studies/history; 'knowledge' actions.
- ~~Curiosity, for science.~~ Logic.
- ~~Intuition, for literature; 'understanding' or 'wise' actions.~~ Learning.
- Health, for P.E.; 'physical' actions.
- Creativity, for music and art; 'creative' actions.
- ~~Speech, for the social component of school; 'persuasive' actions.~~ Creativity?

If language is desired, it can be lumped into Learning ~~or Intuition~~, I think, since grammar is kind of 'intuitive' to understand.

For a prototype, the attributes will be:
- Athletics
- Knowledge
- Charisma

## Activities that use, increase, and/or decrease attributes
Stick RPG has university to increase Intelligence and Strength, and the beggar and bar to increase Charm. These are set-dressing, the important thing is increasing and/or decreasing attributes. Activities that *use* attributes are similar in function; 

## Time wedges, things that use time
It's hard to identify what the time interval is in Stick RPG, but instinctively I think half hours would be good (for a school setting), but hours for a prototype. I'm thinking activities that use time could have a value (in minutes) of how long it would take, and it rounds up to the nearest interval. So an action given that uses even 1 minute rounds up to one interval. This allows for alterations to the interval without much headache, but it could be unnecessary complexity -- it's not very likely that the interval would become a weird 45 minutes, or a very short 15 minutes.

### Rolling over time, tracking days
Once all the intervals are filled, then the day should roll over to the next day. Either it forces the player to go to bed, or it just ticks straight over (requiring a sleep meter). For a high school, a sleep meter and sleep management is very relatable.

## Integration of activities into the game world
Connecting things in the game world to activities is essential to the idea. These are Stick RPG's bar, beggar, university, crack dealer, etc. Interactables that connect to an activity that uses time.

## Yarn integration
This is marked difficult. because I don't know how to do it yet. Dialogue is essential, and I also think that dialogue with other characters and relationship building could be beneficial (especially romantic relationships for high school students). For the prototype, there should be: simple dialogue, the framework of relationships, and shops that supply items.

## Inventory
Similar to Yarn integration, this one is marked difficult because I don't know how to do it yet. Stick RPG likely has things hardcoded, with flags of "has" or "doesn't have." That would be functional for a prototype, and will be what to go with if a more flexible inventory system proves more complicated than I am willing to pursue.

## Any minigames
This one is high complexity because it requires actually thinking of new things. "Any," because I don't think they're necessarily *required,* but I think at least one should exist in the prototype as a proof-of-concept.

## World design
Lastly, world design should be done close to the end as it is less vital. With [world integration](#integration-of-activities-into-the-game-world), it should be easy to rearrange things as needed.

There is the possibility of interiors, too. There could be one in the prototype; at the very least, I think it would be useful to have at least two scenes with a transition between. Stick RPG has "interiors," but none are movable within so I suspect they're just images onscreen -- but either way they're probably still effectively Flash versions of scenes.

## Character movement via WASD over terrain with obstacles (buildings, walls, etc).
I anticipate a hybrid of 2D and 3D -- 2D characters, 3D world possibly mixed with 2D, but orthographic so it is impossible to distinguish the two (other than...frames...). For the prototype, simple capsules is probably good enough; prototyping the visual style is for the second prototype.

Invisible walls are a possibility too; Stick RPG has a park that is not traversible, and a number of other blockages. Interestingly it appears that the world is one image that has been sliced into chunks that are loaded or unloaded as needed; I don't anticipate much need for this with modern computers.

It is possible that character movement isn't necessary at all, simply showing a wide view of everything and clicking on activities. That might be a good first step, and in that case character movement would be moved to the [world design](#world-design) section.

### Alterations to character movement, such as sprinting or riding a vehicle (Stick RPG's skateboard)
Quicker movement would likely be beneficial, and the character should accommodate it even if it doesn't end up in the final prototype.
