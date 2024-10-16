# Lab Explorer

## User Documentation

### About the game
Lab Explorer is a game designed to raise awareness about chemical pollution and its impact on the environment. Chemical pollution occurs when an environment is contaminated, which can happen through soil, water, or air, among other means. This contamination can cause significant disruptions for any organisms living in that space, ranging from the smallest plants to humans, and it can be disastrous for both.
In the game, the character is a scientist who must block off and escape from a lab contaminated by a dangerous substance that has leaked due to a failed experiment. The goal of the game is to help the scientist escape before time runs out and to prevent the surrounding area from being contaminated and taken over by the dangerous life forms created by the experiment.
While creatures may not spawn from failed science experiments in real life, the game teaches us a valuable lesson: like the scientist, we must take care of our environment to prevent further destruction that our activities may cause. In reality, two billion tons of human waste are dumped into rivers every single day. This figure is sourced from the UN Environment Programme’s initiative called Beat Pollution. This clearly illustrates how urgently we need to initiate change.
### Objective
Escape the lab and close it off before the timer which is one minute long runs out.
### Controls 
![The controls and where they are on the keyboard](https://drive.google.com/uc?id=1M0iMvQm_KuyqrSk400oQKy8S0hBTUn2I)
Move: Left arrow, right arrow, A key & D key.
Jump: Space bar & Up arrow.
### Mechanics 
Press S to start the game.
![Title Screen](https://drive.google.com/uc?id=1f2_J7ohA47PDIhhE3Lds7qOBxQA8oRio)
### Music 
Original music composed specifically for game. Do not reuse.
https://www.youtube.com/embed/u9hErvPnv_U
## Playthrough 
[![Watch the video](https://img.youtube.com/vi/VIDEO_ID/0.jpg)](https://drive.google.com/file/d/1g6J64na_5H44lzIquclvvo0CoOojhzFZ/view?usp=drivesdk)

## Development Documentation - Problems and Solutions
### Overall
![Game PLay](https://drive.google.com/uc?id=1AY0jS0Za4ApZgUt1KaEgbgvvSdmDM7jj)
While working on this project, I encountered a variety of challenges. Some issues were resolved quickly, while others persisted for months in the background. Some problems were even incorporated into the game as additional elements.
### Player Movement
During the early stages of the project, I had little to no problems with the movement code, and everything worked normally. However, the movement was quite basic, lacking animation. Additionally, if the jump button was pressed, the character would continue to rise infinitely until the button was released, effectively creating an unwanted "infinite jump."
#### Jump Code
The jump code was the most problematic part throughout the entire project. While following a tutorial that implemented animations for the sprite's movement, I noticed that the jump feature no longer worked. At first, I believed I had made a mistake in the code that caused the error. After spending a lot of time trying to resolve it, I decided that it might be better to leave the jump feature for later and continue adding other animations, hoping the issue might resolve itself.
Unfortunately, after finishing all the animations and adjusting the code, the sprite still couldn't leave the ground, leaving me with a gravity-defying character. This was baffling because there were no compiling errors, and everything appeared to be in order. I checked the colliders, which were present but did not seem to affect the jump mechanics. Eventually, I decided to copy the code directly from the tutorial and test it. To my surprise, the problem persisted.
It dawned on me that the jump code itself wasn't the issue, nor were the box colliders. After consulting additional tutorials and making adjustments to my animations, I was able to restore the jump functionality. The problem lay with the animator, which had not been properly configured.
### Colliders
Throughout the project, I did not face many major issues with colliders. However, they were frequently a source of problems. If the character fell off the screen or phased through a platform, it was usually a simple mistake of not properly adjusting the collider for either the character or the floor object. While troubleshooting the jump code, I checked the colliders and identified several issues. In the long run, this helped me understand the importance of checking colliders early to prevent errors.
Animation and the Animator
Animation was an interesting part of the development process and presented several challenges, some of which were simple to fix, while others took longer. For example, the walking animation had to be redone multiple times because it wasn't fluid or polished enough for my liking.
One particular issue arose with the walk animation. The tutorial I followed provided a walk animation that faced the opposite direction of the one I had created. This caused the sprite to walk backward while the controls were set to move the character in the correct direction. By the end of development, the animator caused more problems, preventing the walk animation from playing. As a result, the character remained in the idle state except when jumping.
### Flipping and Scaling
In the beginning, my assets were at a good scale. However, problems arose with the main camera, which forced me to scale up almost everything by a factor of three. I decided to scale everything in the game because I had deleted the original drawings of my assets to save space on my iPad. To resolve this, I looked for a way to flip the character in-game.
I encountered some issues where the character would appear at the correct size while idle but shrink after moving. This was due to the code not specifying that the sprite should remain scaled up while in motion. The issue was resolved by adding the scaling factor to every line of code that controlled the player's movement.
### Main Camera
At a certain point during development, the game could no longer be viewed through the main camera, which caused some confusion. The obvious solution seemed to be resetting the camera to the default (0, 0, 0) coordinates, but the problem persisted. Interestingly, when I adjusted the camera's angle, the game appeared as a single line, suggesting that it was being viewed from the side. It seemed as though the game was being treated as a 3D plane, which I hadn't anticipated.
### Layering
In the early stages of development, I didn't consider using layers, which led to objects clipping over each other on a single layer. As the project progressed, I had to rearrange the order of certain assets, such as the player sprite, timer, and the main menu screen. This caused some minor issues, but they were relatively easy to fix in the long run.
 
