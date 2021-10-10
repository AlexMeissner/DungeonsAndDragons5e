# Dungeons and Dragons 5e
## ![](https://via.placeholder.com/15/ff0000/000000?text=+) Login
There should be a basic login page and registration page. Optimally, the version of this project is displayed somewhere on this page.

---

## ![](https://via.placeholder.com/15/ff0000/000000?text=+) Campaign Creation & Modification
After logging in, users should be able to create a new campaign. This includes setting a campaign name and adding players to it.

---

## ![](https://via.placeholder.com/15/ff0000/000000?text=+) Campaign Selection
Users who are logged in should see a list of all available campaigns. By clicking on a campaign
the user should open this campaign. If the user is the gamemaster the gamemaster campaign view should be openend. Otherwise, the player campaign view should be opened. More to these views later.
<details>
  <summary>Sample</summary>
  <img src="https://us.v-cdn.net/6022081/uploads/editor/hj/z0fqw0z8r050.jpg">
</details>

---

## ![](https://via.placeholder.com/15/ff0000/000000?text=+) Character Creation
Players which have been invited into a campaign should be able to create a new character. This process should be guided, meaning that values get calculated automatically. During the creation the player should select a class, race, geneder, etc., and roll its core values.

---

## ![](https://via.placeholder.com/15/ff0000/000000?text=+) Map Creation
Map creation is only available for the gamemaster. Map creation contains setting a background image, a grid and optional points of interest. More to them later.

---

## ![](https://via.placeholder.com/15/ff0000/000000?text=+) Map
The map view should contain different layers. The gamemaster has more rights than the players. For example, the gamemaster is allowed to move pc and npc tokens, but the players are only allowded to ping on the map to indicate what they are intending to do.
### ![](https://via.placeholder.com/15/ff0000/000000?text=+) Background Layer
On the lowest layer there should be a background image. This image is a visual representation of the map.
<details>
  <summary>Sample Background</summary>
  <img src="https://www.fantasy-in.de/media/image/87/55/88/dungeons-dragons-baldur-s-gate-map-23-x-17-27947-gfn72792_600x600.jpg">
</details>

### ![](https://via.placeholder.com/15/ff0000/000000?text=+) Grid
Ontop of the background layer there should be a grid. The size (and maybe the form) of the cells needs to be modifiable by the gamemaster during its creation.
<details>
  <summary>Normal Grid Sample</summary>
  <img src="https://www.researchgate.net/profile/Muhammad-Imran/publication/328452819/figure/fig3/AS:684879813562378@1540299480935/The-square-grid-G.png">
</details>
<details>
  <summary>Hex Grid Sample</summary>
  <img src="https://www.researchgate.net/profile/Muhammad-Imran/publication/328452819/figure/fig2/AS:684879813562377@1540299480916/The-hexagonal-grid-H.png">
</details>

### ![](https://via.placeholder.com/15/ff0000/000000?text=+) Object Layer
In order to indicate points of interests like town names, special locations, etc. there should be a layer containing items which consist of an icon and a text. If a player or the gamemaster clicks on such an item, a popup window should appear with additional information about that point of interest. The information panels will be described later.
<details>
  <summary>Sample</summary>
  <img src="https://app.datawrapper.de/static/plugins/locator-maps/img/thumb-locator-map.png">
</details>

### ![](https://via.placeholder.com/15/ff0000/000000?text=+) Tokens
PCs and NPCs should be visualized on another layer by tokens. A token consists of an icon of the character and its name. Additionally, positive and negative effects like feared, bleeding, etc. on that character should be visualized. Tokens can only be moved by the gamemaster and are always aligned inside the grid.
<details>
  <summary>Sample</summary>
  <img src="https://i.redd.it/b96xa0edxx671.png">
</details>

### ![](https://via.placeholder.com/15/ff0000/000000?text=+) Player Pings
Finally, the players and the gamemaster need to be able to point at the map. This should be realized using pings. If a player or the gamemaster clicks somewhere on the map, a circle should popup at this location, visible for all players who are connected to the game. Alternatively, the mouse positions of all players should be indicated at all time, if this does not cost too much bandwidth.
<details>
  <summary>Sample</summary>
  <img src="https://lh3.googleusercontent.com/8t_Ouphd7tYOOfluLwKL7leJAC8GolJRWkoqv23vDHQR6T-G2KtnxuF3cYfqDymCRyIGz9EXZJIi0FtBNhRlvNCsWg=w640-h400-e365-rj-sc0x00ffffff">
</details>

---

## ![](https://via.placeholder.com/15/ff0000/000000?text=+) Rolling Dice
Rolling dice is one of the most important parts of Dungeons and Dragons. For this project, a system similar to *For the King* should be implemented. Instead of rolling a 3D die, multiple textures are colorized red (fail) or green (success). The number of texture depends on the die wich is rolled. For example, a D20 results in 20 textures.
<details>
  <summary>For the King Dice</summary>
  <img src="https://images.mmorpg.com/images/heroes/features/14229.jpg?cb=48639D0094524C51DCA71AFDED70AFA5">
</details>

---

## ![](https://via.placeholder.com/15/ff0000/000000?text=+) Player View
If a player opens a campaign he needs to see all information of its character which is usually written down on a character sheet. The style does not to be of the same type as a character sheet, but all important information needs to be visible.

<details>
  <summary>Character Sheets</summary>
  <img src="https://wow.zamimg.com/uploads/screenshots/normal/764967.jpg">
  <img src="https://i.imgur.com/AwlmHYM.jpg">  
</details>

---

## ![](https://via.placeholder.com/15/ff0000/000000?text=+) Gamemaster View

---

## ![](https://via.placeholder.com/15/ff0000/000000?text=+) Playlists
A very important part of the game is atmosphere. A huge part of atmosphere is created by music. Therefore, the gamemaster should be able to start playlists (combat, spooky, tavern, etc.) or single songs. The music files should **not** be put into this repository, but should be uploaded by the admin into a specific folder. The hierachy inside this folder defines what song is part of what playlist.

---

## ![](https://via.placeholder.com/15/ff0000/000000?text=+) Sound-Effects
Another part of atmosphere are sound effects, like the bell of a church, the sound of two swords clashing against each other and many more. Hence, sound effect file should be placed by the admin into a specific directory which can then be played by the gamemaster during a campaign. Again, these files should **not** be part of the repository.

---

## ![](https://via.placeholder.com/15/ff0000/000000?text=+) Knowlage-Lexicon
During longer campaigns it gets very easy to forget certain events, names, etc. Therefore, a system should be implemented, which stores these kinds of information. For every point of interest, every character, every fight, etc. each player should be able to create its own notes, which only this player can read. This includes the gamemaster. Additionally, there should be a section with general information, which are visible for everyone. Some information might be generated automatically.<br/>
Besides campaign information, rules can be put into this feature. Like class abilities, spells and monster stats.

---

## ![](https://via.placeholder.com/15/ff0000/000000?text=+) Quick Content Creation
When improvising new creations will be generated very quickly. However, some of these creations might generally take a long time to create. Hence, it becomes necessary to have a quick way of creating them on the fly.

### ![](https://via.placeholder.com/15/ff0000/000000?text=+) NPCs
A world lives of its characters. If the players start speaking to unexpected citizens of a town or a random soldier of an amry, information need to be generated for him. However, creating a new character usually takes a lot of time. Therefore, a feature needs to be implemented to create new characters very quickly. The gamemaster should be able to simply click through a short form by selecting the class, race etc. The gamemaster should have the ability to either choose all values by hand, or to let them be generated on random. Random for faster generation and by hand for fitting the current needs. 

### ![](https://via.placeholder.com/15/ff0000/000000?text=+) Maps
There may be some moments in which the players to something the gamemaster does not expect. For example they go somewhere they where not supposed to, or they start a fight out of nowhere. For that reason, the map creation feature should be extented in such a way, that there are some predefined resources the gamemaster can use. Like for example a collection of background images for taverns, battlefields, etc. It may be desirable to create a new map based on the current map, but this time it is a fight map.

---

## ![](https://via.placeholder.com/15/ff0000/000000?text=+) Combat
Another essential part of *Dungeons and Dragons* is combat. During larger fights it gets easy to forget the initative order. Therefore, a system should be developed, which visualizes this order, not only for the players, but also for the enemies.
<details>
  <summary>Sample</summary>
  <img src="https://dmdavid.com/wp-content/uploads/2013/03/Gamemastery_Combat_Pad.jpeg">
</details>

Besides the gamemaster needs to be able to see how much health each character has left. Players should **not** see this information in order to make fights more interesting. In *reality* the characters do not have this information. This would be *meta gaming*.

---

## ![](https://via.placeholder.com/15/ff0000/000000?text=+) Combat Generator
Creating and balancing combat encounters is not an easy task. However, there are tools which allow the gamemaster to determine the difficulty of an encounter. The gamemaster should be able to put 2 parties together. One party includes the players and their allies. The other party contains the enemies. Based on the compositions the difficulty can be determined.
<details>
  <summary>Sample</summary>
  <img src="https://dndbeyond.zendesk.com/hc/article_attachments/360036589833/mceclip0.png">
</details>
During the quick creation the gamemaster should also be able to select a battle map.

---

## ![](https://via.placeholder.com/15/ff0000/000000?text=+) Backup System
During updates there is always the chance of breaking something. Additionally, someting unexpected might happen to the host. As a result, a backup system should be implemented, which stores the database and all resources which are not part of the deployment into a compressed container, which can be downloaded by the admin to a different machine. If some error occurs, this backup should be uploadable to the server again, restoring the old state.

---

## ![](https://via.placeholder.com/15/ff0000/000000?text=+) Automatic Deployment
It takes some time to build and deploy by hand. In addtion, human errors may occur during this process. Therefore, the repository should be build and deployed to the webhost, after each push to the *master branch*.