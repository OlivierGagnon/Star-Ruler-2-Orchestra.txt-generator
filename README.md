# Star-Ruler-2-Orchestra.txt-generator
Star Ruler 2 Orchestra.txt generator

You can use this to generate an orchestra.txt file, which is a playlist for Star Ruler 2

Game was recently open sourced without music, so here's a way to add your own!

Source of the game is here: https://github.com/BlindMindStudios/StarRuler2-Source

I spent some time to analyze the orchestra.txt and do some tests, and the way it's generated now is the most efficient way to make it.
There used to be more stuff, but it's not implemented or doesn't work, so what actually works is what this program generates

How to use:

Open the program. Third tab to add ogg files to the playlist. Double click to remove. 4th tab for adding victory songs, 5th for defeat songs. These will play when you're in an epic battle and either you or your opponent has most ships killed.

6th tab to create orchestra.txt in the folder where this exe resides

Copy everything to music folder under data in SR2 folder.

Screenshot: https://imgur.com/a/GytrYhZ

IF YOUR GAME CRASHES A LOT AFTER ADDING YOUR MUSIC:
Game seems picky about ogg encoding and it may result in lots of crashing.
re-encode all your ogg files with winlame static bitrate, should fix the issue
